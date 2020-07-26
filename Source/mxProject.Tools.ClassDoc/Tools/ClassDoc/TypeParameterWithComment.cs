using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Type parameter and its XML comment.
    /// </summary>
    public class TypeParameterWithComment
    {

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="parameterType">The generic parameter type.</param>
        /// <param name="commentGetter">The method to get comment of parameter.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public TypeParameterWithComment(Type parameterType, Func<ParameterComment> commentGetter, ClassDocContext context)
        {
            ParameterType = parameterType;
            Context = context;
            m_CommentGetter = commentGetter;
        }

        /// <summary>
        /// Gets the generic parameter type.
        /// </summary>
        public Type ParameterType { get; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        private ClassDocContext Context { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get { return ParameterType.Name; }
        }

        /// <summary>
        /// Gets the parameter attributes.
        /// </summary>
        public GenericParameterAttributes Attributes
        {
            get { return ParameterType.GenericParameterAttributes; }
        }

        /// <summary>
        /// Gets the constraint types.
        /// </summary>
        /// <returns></returns>
        public TypeWithComment[] GetConstraintTypes()
        {
            Type[] types = ParameterType.GetGenericParameterConstraints();
            List<TypeWithComment> list = new List<TypeWithComment>();

            for (int i = 0; i < types.Length; ++i)
            {
                if (types[i] == typeof(ValueType) && ((ParameterType.GenericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) > 0)) { continue; }
                list.Add(Context.GetTypeInfo(types[i]));
            }

            return list.ToArray();
        }

        #region comment

        /// <summary>
        /// Gets the XML comment.
        /// </summary>
        public ParameterComment Comment
        {
            get
            {
                return m_CommentGetter() ?? ParameterComment.Empty;
            }
        }

        /// <summary>
        /// The method to get comment of parameter.
        /// </summary>
        private readonly Func<ParameterComment> m_CommentGetter;

        #endregion

    }

}
