using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// A context that manages the state of the output process for class documents.
    /// </summary>
    public class ClassDocContext
    {

        /// <summary>
        /// null instance.
        /// </summary>
        internal static readonly ClassDocContext Null = new ClassDocContext();

        #region filters

        /// <summary>
        /// Gets or sets the method that determines if the specified type is an output target.
        /// </summary>
        public Func<Type, bool> TypeFilter { get; set; } = TypeExtenstions.IsRecommendOutputToDocument;

        /// <summary>
        /// Gets or sets the method that determines if the specified constructor is an output target.
        /// </summary>
        public Func<ConstructorInfo, bool> ConstructorFilter { get; set; } = ConstructorInfoExtensions.IsRecommendOutputToDocument;

        /// <summary>
        /// Gets or sets the method that determines if the specified method is an output target.
        /// </summary>
        public Func<MethodInfo, bool> MethodFilter { get; set; } = MethodInfoExtensions.IsRecommendOutputToDocument;

        /// <summary>
        /// Gets or sets the method that determines if the specified property is an output target.
        /// </summary>
        public Func<PropertyInfo, bool> PropertyFilter { get; set; } = PropertyInfoExtensions.IsRecommendOutputToDocument;

        /// <summary>
        /// Gets or sets the method that determines if the specified field is an output target.
        /// </summary>
        public Func<FieldInfo, bool> FieldFilter { get; set; } = FieldInfoExtensions.IsRecommendOutputToDocument;

        /// <summary>
        /// Gets or sets the method that determines if the specified event is an output target.
        /// </summary>
        public Func<EventInfo, bool> EventFilter { get; set; } = EventInfoExtensions.IsRecommendOutputToDocument;
        
        #endregion

        #region type informations

        private readonly Dictionary<Type, TypeWithComment> m_Types = new Dictionary<Type, TypeWithComment>();

        /// <summary>
        /// Stores the specified type of information.
        /// </summary>
        /// <param name="type">The type information.</param>
        internal void StoreTypeInfo(TypeWithComment type)
        {
            if (type.Info.IsConstructedGenericType)
            {
                // m_Types[type.Info.GetGenericTypeDefinition()] = type;
                m_Types[type.Info] = type;
            }
            else
            {
                m_Types[type.Info] = type;
            }

            if (type.Comment != null && !type.Comment.IsEmpty)
            {
                m_TypeComments[type.Comment.Signature] = type;
            }

            foreach (var method in type.Methods)
            {
                if (method.Comment.IsEmpty) { continue; }
                m_MethodComments[method.Comment.Signature] = method;
            }

            foreach (var prop in type.Properties)
            {
                if (prop.Comment.IsEmpty) { continue; }
                m_PropertyComments[prop.Comment.Signature] = prop;
            }

            foreach (var field in type.Fields)
            {
                if (field.Comment.IsEmpty) { continue; }
                m_FieldComments[field.Comment.Signature] = field;
            }

            foreach (var evt in type.Events)
            {
                if (evt.Comment.IsEmpty) { continue; }
                m_EventComments[evt.Comment.Signature] = evt;
            }
        }

        /// <summary>
        /// Gets the specified type of information.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="found">The Type information found.</param>
        /// <returns>Returns true if found. Otherwise, false.</returns>
        private bool TryGetTypeInfo(Type type, out TypeWithComment? found)
        {
            if (type.IsConstructedGenericType)
            {
                // return m_Types.TryGetValue(type.GetGenericTypeDefinition(), out found);
                return m_Types.TryGetValue(type, out found);
            }
            else
            {
                return m_Types.TryGetValue(type, out found);
            }
        }

        /// <summary>
        /// Gets the specified type of information. If no XML comment is found, returns empty XML comment information.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The type information.</returns>
        public TypeWithComment GetTypeInfo(Type type)
        {
            if (TryGetTypeInfo(type, out var info) && info != null) { return info; }

            info = new TypeWithComment(type, null, this);

            StoreTypeInfo(info);

            return info;
        }

        #endregion

        #region xml comments

        /// <summary>
        /// xml comments for types.
        /// </summary>
        private readonly Dictionary<XmlCommentSignature, TypeWithComment> m_TypeComments = new Dictionary<XmlCommentSignature, TypeWithComment>();

        /// <summary>
        /// Gets information for the specified type.
        /// </summary>
        /// <param name="typeSignature">XML comment signature.</param>
        /// <param name="type">The type information.</param>
        /// <returns>Returns true if found. Otherwise, false.</returns>
        internal bool TryGetTypeInfo(XmlCommentSignature typeSignature, out TypeWithComment type)
        {
            return m_TypeComments.TryGetValue(typeSignature, out type);
        }

        /// <summary>
        /// xml comments for methods.
        /// </summary>
        private readonly Dictionary<XmlCommentSignature, MethodInfoWithComment> m_MethodComments = new Dictionary<XmlCommentSignature, MethodInfoWithComment>();

        /// <summary>
        /// Gets information for the specified method.
        /// </summary>
        /// <param name="methodSignature">XML comment signature.</param>
        /// <param name="method">The method information.</param>
        /// <returns>Returns true if found. Otherwise, false.</returns>
        internal bool TryGetMethodInfo(XmlCommentSignature methodSignature, out MethodInfoWithComment method)
        {
            return m_MethodComments.TryGetValue(methodSignature, out method);
        }

        /// <summary>
        /// xml comments for properties.
        /// </summary>
        private readonly Dictionary<XmlCommentSignature, PropertyInfoWithComment> m_PropertyComments = new Dictionary<XmlCommentSignature, PropertyInfoWithComment>();

        /// <summary>
        /// Gets information for the specified property.
        /// </summary>
        /// <param name="propertySignature">XML comment signature.</param>
        /// <param name="property">The property information.</param>
        /// <returns>Returns true if found. Otherwise, false.</returns>
        internal bool TryGetPropertyInfo(XmlCommentSignature propertySignature, out PropertyInfoWithComment property)
        {
            return m_PropertyComments.TryGetValue(propertySignature, out property);
        }

        /// <summary>
        /// xml comments for fields.
        /// </summary>
        private readonly Dictionary<XmlCommentSignature, FieldInfoWithComment> m_FieldComments = new Dictionary<XmlCommentSignature, FieldInfoWithComment>();

        /// <summary>
        /// Gets information for the specified field.
        /// </summary>
        /// <param name="fieldSignature">XML comment signature.</param>
        /// <param name="field">The field information.</param>
        /// <returns>Returns true if found. Otherwise, false.</returns>
        internal bool TryGetFieldInfo(XmlCommentSignature fieldSignature, out FieldInfoWithComment field)
        {
            return m_FieldComments.TryGetValue(fieldSignature, out field);
        }

        /// <summary>
        /// xml comments for events.
        /// </summary>
        private readonly Dictionary<XmlCommentSignature, EventInfoWithComment> m_EventComments = new Dictionary<XmlCommentSignature, EventInfoWithComment>();

        /// <summary>
        /// Gets information for the specified event.
        /// </summary>
        /// <param name="eventSignature">XML comment signature.</param>
        /// <param name="evt">The event information.</param>
        /// <returns>Returns true if found. Otherwise, false.</returns>
        internal bool TryGetEventInfo(XmlCommentSignature eventSignature, out EventInfoWithComment evt)
        {
            return m_EventComments.TryGetValue(eventSignature, out evt);
        }

        #endregion

    }
}
