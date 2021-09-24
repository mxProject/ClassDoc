using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using Cysharp.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Type information and its XML comment.
    /// </summary>
    public sealed class TypeWithComment
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="commentLookup">The XML comment of the type and the members.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public TypeWithComment(Type type, ILookup<string, XmlComment>? commentLookup, ClassDocContext context)
        {
            Context = context;
            m_CommentLookup = commentLookup;

            this.Info = type;
            
            GenericParameterTypes = CreateGenericParameters().AsReadOnly();
            Constructors = CreateConstructors().AsReadOnly();
            Methods = CreateMethodList().AsReadOnly();
            Properties = CreatePropertyList().AsReadOnly();
            Fields = CreateFieldList().AsReadOnly();
            Events = CreateEventList().AsReadOnly();

            if (commentLookup == null)
            {
                Comment = XmlComment.Empty;
            }
            else
            {
                string typeName = type.FullName.Replace('+', '.');
                Comment = commentLookup[typeName].Where(x => x.Kind == XmlCommentKind.Type && x.TypeName == typeName).FirstOrDefault() ?? XmlComment.Empty;
            }

            DelegateMethodInfo = CreateDelegateMethodInfo();
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        internal ClassDocContext Context { get; }

        /// <summary>
        /// The XML comment of the type and the members.
        /// </summary>
        private readonly ILookup<string, XmlComment>? m_CommentLookup;

        /// <summary>
        /// Gets the type information.
        /// </summary>
        public Type Info { get; }

        /// <summary>
        /// Gets whether it is obsolete.
        /// </summary>
        public bool IsObsolete => Info.IsObsolete();

        /// <summary>
        /// Gets the XML comment.
        /// </summary>
        public XmlComment Comment { get; }

        /// <summary>
        /// Gets the namespace.
        /// </summary>
        public string Namespace => Info.Namespace;

        /// <summary>
        /// Gets the fully qualified name of the type.
        /// </summary>
        public string FullName
        {
            get { return Info.FullName; }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                if (Info.IsNested)
                {
                    return ZString.Concat(Context.GetTypeInfo(Info.DeclaringType).Name, ".", Info.Name);
                }
                else
                {
                    return Info.Name;
                }
            }
        }

        /// <summary>
        /// Goes up the inheritance tree and enumerates the base types.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TypeWithComment> EnumerateBaseTypes()
        {
            foreach (Type type in Info.EnumerateBaseTypes())
            {
                yield return Context.GetTypeInfo(type);
            }
        }

        /// <summary>
        /// Gets whether it implements the interface.
        /// </summary>
        public bool HasImplementedInterfaces
        {
            get { return Info.GetInterfaces().Length > 0; }
        }

        /// <summary>
        /// Enumerates the implemented interface types.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TypeWithComment> EnumerateImplementedInterfaces()
        {
            foreach (Type type in Info.GetInterfaces())
            {
                yield return Context.GetTypeInfo(type);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the type is a class, exclude interface and delegate.
        /// </summary>
        public bool IsClass
        {
            get { return Info.IsClassExcludeDelegateAndInterface(); }
        }

        /// <summary>
        /// Gets a value indicating whether the type is a valyeType, exclude enumeration.
        /// </summary>
        public bool IsValueType
        {
            get { return Info.IsValueType && !Info.IsEnum; }
        }

        /// <summary>
        /// Gets a value indicating whether the type is an enumeration.
        /// </summary>
        public bool IsEnum
        {
            get { return Info.IsEnum; }
        }

        /// <summary>
        /// Gets a value indicating whether the type is a delegate.
        /// </summary>
        public bool IsDelegate
        {
            get { return Info.IsDelegate(); }
        }

        /// <summary>
        /// Gets a value indicating whether the type is an interface.
        /// </summary>
        public bool IsInterface
        {
            get { return Info.IsInterface; }
        }

        #region generic parameters

        /// <summary>
        /// Gets a value indicating whether this type represents a generic type definition.
        /// </summary>
        public bool IsGenericTypeDefinition
        {
            get { return Info.IsGenericTypeDefinition; }
        }

        /// <summary>
        /// Gets the generic parameters.
        /// </summary>
        public IReadOnlyList<TypeParameterWithComment> GenericParameterTypes { get; }

        /// <summary>
        /// Creates a generic parameter list.
        /// </summary>
        /// <returns></returns>
        private List<TypeParameterWithComment> CreateGenericParameters()
        {
            List<TypeParameterWithComment> list = new List<TypeParameterWithComment>();

            foreach (var type in Info.GetGenericArguments())
            {
                list.Add(new TypeParameterWithComment(type, () => GetGenericParameterComment(type), Context));
            }

            return list;
        }

        /// <summary>
        /// Gets the comment of the specified parameter type.
        /// </summary>
        /// <param name="parameterType">The parameter type.</param>
        /// <returns></returns>
        private ParameterComment GetGenericParameterComment(Type parameterType)
        {
            if (Comment.TypeParameters.TryGetValue(parameterType.Name, out ParameterComment parameterComment))
            {
                return parameterComment;
            }

            if (Info.IsNested)
            {
                return Context.GetTypeInfo(Info.DeclaringType).GetGenericParameterComment(parameterType);
            }

            return new ParameterComment(parameterType.Name, Context);
        }

        #endregion

        #region constractors

        /// <summary>
        /// Gets the constructors.
        /// </summary>
        public IReadOnlyList<ConstructorInfoWithComment> Constructors { get; }

        /// <summary>
        /// Creates a list that stores information for the constructors.
        /// </summary>
        /// <returns></returns>
        private List<ConstructorInfoWithComment> CreateConstructors()
        {
            List<ConstructorInfoWithComment> list = new List<ConstructorInfoWithComment>();

            var commentsOfMethod = m_CommentLookup?[Info.FormatToXmlCommentTypeName()].Where(x => x.Kind == XmlCommentKind.Method).ToDictionary(x => x.SignatureName);

            foreach (var ctor in Info.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            {
                if (Context.ConstructorFilter != null && !Context.ConstructorFilter(ctor)) { continue; }

                var signature = ctor.FormatToXmlCommentSignature();

                XmlComment? comment = null;

                if (commentsOfMethod != null && !commentsOfMethod.TryGetValue(signature, out comment))
                {
                    // not found
                }

                list.Add(new ConstructorInfoWithComment(ctor, comment ?? XmlComment.Empty, Context));
            }

            list.Sort((a, b) => a.Info.FormatToReadableSignature().CompareTo(b.Info.FormatToReadableSignature()));

            return list;
        }

        #endregion

        #region methods

        /// <summary>
        /// Gets the methods.
        /// </summary>
        public IReadOnlyList<MethodInfoWithComment> Methods { get; }

        /// <summary>
        /// Gets whether the instance method exists.
        /// </summary>
        public bool HasInstanceMethod
        {
            get
            {
                foreach (var method in Methods)
                {
                    if (!method.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets whether the static method exists.
        /// </summary>
        public bool HasStaticMethod
        {
            get
            {
                foreach (var method in Methods)
                {
                    if (method.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Creates a list that stores information for the methods.
        /// </summary>
        /// <returns></returns>
        private List<MethodInfoWithComment> CreateMethodList()
        {
            List<MethodInfoWithComment> list = new List<MethodInfoWithComment>();

            var commentsOfMethod = m_CommentLookup?[Info.FormatToXmlCommentTypeName()].Where(x => x.Kind == XmlCommentKind.Method).ToDictionary(x => x.SignatureName);

            foreach (var method in Info.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            {
                if (Context.MethodFilter != null && !Context.MethodFilter(method)) { continue; }
                
                var signature = method.FormatToXmlCommentSignature();

                XmlComment? comment = null;

                if (commentsOfMethod != null && !commentsOfMethod.TryGetValue(signature, out comment))
                {
                    // not found
                }

                list.Add(new MethodInfoWithComment(method, comment ?? XmlComment.Empty, Context));
            }

            list.Sort((a, b) => a.Info.FormatToReadableSignature().CompareTo(b.Info.FormatToReadableSignature()));

            return list;
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets the properties.
        /// </summary>
        public IReadOnlyList<PropertyInfoWithComment> Properties { get; }

        /// <summary>
        /// Gets whether the instance property exists.
        /// </summary>
        public bool HasInstanceProperty
        {
            get
            {
                foreach (var prop in Properties)
                {
                    if (!prop.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets whether the static property exists.
        /// </summary>
        public bool HasStaticProperty
        {
            get
            {
                foreach (var prop in Properties)
                {
                    if (prop.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Creates a list that stores information for the properties.
        /// </summary>
        /// <returns></returns>
        private List<PropertyInfoWithComment> CreatePropertyList()
        {
            List<PropertyInfoWithComment> list = new List<PropertyInfoWithComment>();

            Dictionary<string?, XmlComment> comments = new Dictionary<string?, XmlComment>();

            if (m_CommentLookup != null)
            {
                foreach (var comment in m_CommentLookup[Info.FormatToXmlCommentTypeName()].Where(x => x.Kind == XmlCommentKind.Property))
                {
                    if (string.IsNullOrEmpty(comment.MethodArguments))
                    {
                        comments.Add(comment.MemberName, comment);
                    }
                    else
                    {
                        // indexer
                        comments.Add(ZString.Concat(comment.MemberName, comment.MethodArguments), comment);
                    }
                }
            }

            foreach (var prop in Info.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.SetProperty))
            {
                if (Context.PropertyFilter != null && !Context.PropertyFilter(prop)) { continue; }

                var name = ZString.CreateStringBuilder();

                name.Append(prop.Name);

                var parameters = prop.GetIndexParameters();

                if (parameters != null && parameters.Length > 0)
                {
                    name.Append("(");

                    for (int i = 0; i < parameters.Length; ++i)
                    {
                        if (i > 0) { name.Append(","); }

                        Type[] typeGenerigArgs = Type.EmptyTypes;

                        if (prop.DeclaringType.IsGenericType)
                        {
                            typeGenerigArgs = prop.DeclaringType.GetGenericArguments();
                        }

                        name.Append(parameters[i].ParameterType.FormatToXmlCommentParameterTypeName(typeGenerigArgs, Type.EmptyTypes));
                    }

                    name.Append(")");
                }

                comments.TryGetValue(name.ToString(), out var comment);

                list.Add(new PropertyInfoWithComment(prop, comment, Context));
            }

            list.Sort((a, b) => a.Info.FormatToReadableSignature().CompareTo(b.Info.FormatToReadableSignature()));

            return list;
        }

        #endregion

        #region fields

        /// <summary>
        /// Gets the fields.
        /// </summary>
        public IReadOnlyList<FieldInfoWithComment> Fields { get; }

        /// <summary>
        /// Gets whether the instance field exists.
        /// </summary>
        public bool HasInstanceField
        {
            get
            {
                foreach (var field in Fields)
                {
                    if (!field.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets whether the static field exists.
        /// </summary>
        public bool HasStaticField
        {
            get
            {
                foreach (var field in Fields)
                {
                    if (field.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Creates a list that stores information for the fields.
        /// </summary>
        /// <returns></returns>
        private List<FieldInfoWithComment> CreateFieldList()
        {
            List<FieldInfoWithComment> list = new List<FieldInfoWithComment>();

            Dictionary<string?, XmlComment> comments = new Dictionary<string?, XmlComment>();

            if (m_CommentLookup != null)
            {
                foreach (var comment in m_CommentLookup[Info.FormatToXmlCommentTypeName()].Where(x => x.Kind == XmlCommentKind.Field))
                {
                    comments.Add(comment.MemberName, comment);
                }
            }

            foreach (var field in Info.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.GetField | BindingFlags.SetField))
            {
                if (Context.FieldFilter != null && !Context.FieldFilter(field)) { continue; }

                var name = ZString.CreateStringBuilder();

                name.Append(field.Name);

                comments.TryGetValue(name.ToString(), out var comment);

                list.Add(new FieldInfoWithComment(field, comment, Context));
            }

            list.Sort((a, b) => a.Info.Name.CompareTo(b.Info.Name));

            return list;
        }

        #endregion

        #region events

        /// <summary>
        /// Gets the events.
        /// </summary>
        public IReadOnlyList<EventInfoWithComment> Events { get; }

        /// <summary>
        /// Gets whether the instance field exists.
        /// </summary>
        public bool HasInstanceEvent
        {
            get
            {
                foreach (var evt in Events)
                {
                    if (!evt.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Gets whether the static field exists.
        /// </summary>
        public bool HasStaticEvent
        {
            get
            {
                foreach (var evt in Events)
                {
                    if (evt.IsStatic) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// Creates a list that stores information for the events.
        /// </summary>
        /// <returns></returns>
        private List<EventInfoWithComment> CreateEventList()
        {
            List<EventInfoWithComment> list = new List<EventInfoWithComment>();

            Dictionary<string?, XmlComment> comments = new Dictionary<string?, XmlComment>();

            if (m_CommentLookup != null)
            {
                foreach (var comment in m_CommentLookup[Info.FormatToXmlCommentTypeName()].Where(x => x.Kind == XmlCommentKind.Event))
                {
                    comments.Add(comment.MemberName, comment);
                }
            }

            foreach (var evt in Info.GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            {
                if (Context.EventFilter != null && !Context.EventFilter(evt)) { continue; }

                var name = ZString.CreateStringBuilder();

                name.Append(evt.Name);

                comments.TryGetValue(name.ToString(), out var comment);

                list.Add(new EventInfoWithComment(evt, comment, Context));
            }

            list.Sort((a, b) => a.Info.Name.CompareTo(b.Info.Name));

            return list;
        }

        #endregion

        #region delegate

        /// <summary>
        /// Gets the delegate method information.
        /// </summary>
        private MethodInfoWithComment? DelegateMethodInfo { get; }

        /// <summary>
        /// Creates a delegate method information.
        /// </summary>
        /// <returns></returns>
        private MethodInfoWithComment? CreateDelegateMethodInfo()
        {
            if (!Info.IsDelegate()) { return null; }

            MethodInfo method = Info.GetMethod("Invoke");

            if (method == null) { return null; }

            return new MethodInfoWithComment(method, Comment, Context);
        }

        /// <summary>
        /// Gets the delegate parameters.
        /// </summary>
        public IReadOnlyList<ParameterInfoWithComment>? DelegateParameters
        {
            get { return DelegateMethodInfo?.Parameters; }
        }

        /// <summary>
        /// Gets whether the delegate returns a return value.
        /// </summary>
        public bool HasDelegateReturnValue
        {
            get { return DelegateMethodInfo == null ? false : DelegateMethodInfo.HasReturnValue; }
        }

        /// <summary>
        /// Gets the declaretion statement.
        /// </summary>
        /// <returns></returns>
        public string GetDelegateDeclaretion()
        {
            if (DelegateMethodInfo == null) { return ""; }

            MethodInfo method = DelegateMethodInfo.Info;

            var genericArgs =  Info.IsGenericType ? Info.GetGenericArguments() : Type.EmptyTypes;

            var sb = ZString.CreateStringBuilder();

            sb.Append("delegate ");

            // return value

            sb.Append(method.ReturnType.FormatToReadableTypeName(false));

            // name

            sb.Append(" ");
            sb.Append(Info.FormatToReadableTypeName(false));

            // arguments

            var parameters = method.GetParameters();

            if (parameters.Length > 0)
            {
                sb.AppendLine();
                sb.Append("(");

                for (int i = 0; i < parameters.Length; ++i)
                {
                    sb.AppendLine();
                    sb.Append("\t");

                    if (i > 0) { sb.Append(", "); }

                    if (parameters[i].IsIn) { sb.Append("in "); }
                    if (parameters[i].IsOut) { sb.Append("out "); }

                    sb.Append(parameters[i].ParameterType.FormatToReadableTypeName(false));

                    sb.Append(" ");
                    sb.Append(parameters[i].Name);
                }

                sb.AppendLine();
                sb.Append(")");
            }
            else
            {
                sb.Append("()");
            }

            // generic constraint

            foreach (var genericArg in genericArgs)
            {
                bool foundConstraint = false;

                foreach (var constraint in ClassDocUtility.EnumerateGenericConstraints(genericArg))
                {
                    if (foundConstraint)
                    {
                        sb.Append(", ");
                    }
                    else
                    {
                        sb.AppendLine();
                        sb.AppendFormat("where {0} : ", genericArg.Name);
                        foundConstraint = true;
                    }
                    sb.Append(constraint);
                }
            }

            return sb.ToString();

        }

        #endregion

    }

}
