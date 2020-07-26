using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Generic class with one type parameter declared.
    /// </summary>
    /// <typeparam name="T1">1st type parameter.</typeparam>
    public class GenericClass<T1>
        where T1 : class
    {

        /// <summary>
        /// ctor.
        /// </summary>
        public GenericClass()
        {
        }

        /// <summary>
        /// A method that takes the type parameter.
        /// </summary>
        /// <param name="t1">argument.</param>
        public void Action(T1 t1) { }

        /// <summary>
        /// A method that returns the type parameter.
        /// </summary>
        /// <returns>Return value.</returns>
        public T1 Func() { return default; }

        /// <summary>
        /// A generic method that takes the type parameter and the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="m1">2nd argument.</param>
        public void GenericAction<M1>(T1 t1, M1 m1) { }

        /// <summary>
        /// A generic method that takes the type parameter and the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="m1">1st argument.</param>
        /// <param name="t1">2nd argument.</param>
        public void GenericAction<M1>(M1 m1, T1 t1) { }

        /// <summary>
        /// A generic method that returns the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="t1">argument.</param>
        /// <returns>Return value.</returns>
        public M1 GenericFunc<M1>(T1 t1) { return default; }

        /// <summary>
        /// A generic method that takes the type parameter of this method, and returns the type parameter.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="m1">argument.</param>
        /// <returns>Return value.</returns>
        public T1 GenericFunc<M1>(M1 m1) { return default; }


        /// <summary>
        /// Nested class.
        /// </summary>
        public class NestedClass
        {
            /// <summary>
            /// A method that takes the type parameter.
            /// </summary>
            /// <param name="t1">argument.</param>
            public void Action(T1 t1) { }

            /// <summary>
            /// A generic method that takes the type parameter and the type parameter of this method.
            /// </summary>
            /// <typeparam name="M1">1st type parameter of this method.</typeparam>
            /// <param name="t1">1st argument.</param>
            /// <param name="m1">2nd argument.</param>
            public void GenericAction<M1>(T1 t1, M1 m1) { }
        }

        /// <summary>
        /// Nested generic class.
        /// </summary>
        /// <typeparam name="N1">1st type parameter.</typeparam>
        public class GenericNestedClass<N1>
        {
            /// <summary>
            /// A method that takes the type parameter.
            /// </summary>
            /// <param name="t1">1st argument.</param>
            /// <param name="n1">2nd argument.</param>
            public void Action(T1 t1, N1 n1) { }

            /// <summary>
            /// A generic method that takes the type parameter and the type parameter of this method.
            /// </summary>
            /// <typeparam name="M1">1st type parameter of this method.</typeparam>
            /// <param name="t1">1st argument.</param>
            /// <param name="n1">2nd argument.</param>
            /// <param name="m1">3rd argument.</param>
            public void GenericAction<M1>(T1 t1, N1 n1, M1 m1) { }
        }

    }

    /// <summary>
    /// Generic class with two type parameters declared.
    /// </summary>
    /// <typeparam name="T1">1st type parameter.</typeparam>
    /// <typeparam name="T2">2nd type parameter.</typeparam>
    public class GenericClass<T1, T2>
        where T1 : class, new()
        where T2 : struct
    {

        /// <summary>
        /// ctor.
        /// </summary>
        public GenericClass()
        {
        }

        /// <summary>
        /// A method that takes the type parameter, <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="t1">argument.</param>
        public void Action(T1 t1) { }

        /// <summary>
        /// A method that takes the type parameter, <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="t2">argument.</param>
        public void Action(T2 t2) { }

        /// <summary>
        /// A method that takes the type parameter, <typeparamref name="T1"/> and <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        public void Action(T1 t1, T2 t2) { }

        /// <summary>
        /// A method that returns the type parameter, <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="t1">argument.</param>
        /// <returns>Return value.</returns>
        public T2 Func(T1 t1) { return default; }

        /// <summary>
        /// A method that returns the type parameter, <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="t2">argument.</param>
        /// <returns>Return value.</returns>
        public T1 Func(T2 t2) { return default; }

        /// <summary>
        /// A generic method that takes the type parameter and the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <param name="m1">3rd argument.</param>
        public void GenericAction<M1>(T1 t1, T2 t2, M1 m1) { }

        /// <summary>
        /// A generic method that takes the type parameter and the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="m1">2nd argument.</param>
        /// <param name="t2">3rd argument.</param>
        public void GenericAction<M1>(T1 t1, M1 m1, T2 t2) { }

        /// <summary>
        /// A generic method that takes the type parameter and the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <typeparam name="M2">2nd type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <param name="m1">3rd argument.</param>
        /// <param name="m2">4th argument.</param>
        public void GenericAction<M1, M2>(T1 t1, T2 t2, M1 m1, M2 m2) { }

        /// <summary>
        /// A generic method that takes the type parameter and the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <typeparam name="M2">2nd type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="m1">2nd argument.</param>
        /// <param name="t2">3rd argument.</param>
        /// <param name="m2">4th argument.</param>
        public void GenericAction<M1, M2>(T1 t1, M1 m1, T2 t2, M2 m2) { }

        /// <summary>
        /// A generic method that returns the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <returns>Return value.</returns>
        public M1 GenericFunc<M1>(T1 t1, T2 t2) { return default; }

        /// <summary>
        /// A generic method that takes the type parameter of this method, and returns the type parameter.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <param name="m1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <returns>Return value.</returns>
        public T1 GenericFunc<M1>(M1 m1, T2 t2) { return default; }

        /// <summary>
        /// A generic method that returns the type parameter of this method.
        /// </summary>
        /// <typeparam name="M1">1st type parameter of this method.</typeparam>
        /// <typeparam name="M2">2nd type parameter of this method.</typeparam>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <param name="m1">3rd argument.</param>
        /// <returns>Return value.</returns>
        public M2 GenericFunc<M1, M2>(T1 t1, T2 t2, M1 m1) { return default; }


        /// <summary>
        /// Nested class.
        /// </summary>
        public class NestedClass
        {
            /// <summary>
            /// A method that takes the type parameter.
            /// </summary>
            /// <param name="t1">1st argument.</param>
            /// <param name="t2">2nd argument.</param>
            public void Action(T1 t1, T2 t2) { }

            /// <summary>
            /// A generic method that takes the type parameter and the type parameter of this method.
            /// </summary>
            /// <typeparam name="M1">1st type parameter of this method.</typeparam>
            /// <typeparam name="M2">2st type parameter of this method.</typeparam>
            /// <param name="t1">1st argument.</param>
            /// <param name="m1">2nd argument.</param>
            /// <param name="t2">3rd argument.</param>
            /// <param name="m2">4th argument.</param>
            public void GenericAction<M1, M2>(T1 t1, M1 m1, T2 t2, M2 m2) { }
        }

        /// <summary>
        /// Nested generic class.
        /// </summary>
        /// <typeparam name="N1">1st type parameter.</typeparam>
        /// <typeparam name="N2">2nd type parameter.</typeparam>
        public class GenericNestedClass<N1, N2>
        {
            /// <summary>
            /// A method that takes the type parameter.
            /// </summary>
            /// <param name="t1">1st argument.</param>
            /// <param name="n1">2nd argument.</param>
            /// <param name="t2">3rd argument.</param>
            /// <param name="n2">4th argument.</param>
            public void Action(T1 t1, N1 n1, T2 t2, N2 n2) { }

            /// <summary>
            /// A generic method that takes the type parameter and the type parameter of this method.
            /// </summary>
            /// <typeparam name="M1">1st type parameter of this method.</typeparam>
            /// <typeparam name="M2">2st type parameter of this method.</typeparam>
            /// <param name="t1">1st argument.</param>
            /// <param name="n1">2nd argument.</param>
            /// <param name="m1">3rd argument.</param>
            /// <param name="t2">4th argument.</param>
            /// <param name="m2">5th argument.</param>
            /// <param name="n2">6th argument.</param>
            public void GenericAction<M1, M2>(T1 t1, N1 n1, M1 m1, T2 t2, N2 n2, M2 m2) { }
        }

    }

    /// <summary>
    /// Generic class with three type parameters declared.
    /// </summary>
    /// <typeparam name="T1">1st type parameter.</typeparam>
    /// <typeparam name="T2">2nd type parameter.</typeparam>
    /// <typeparam name="T3">3rd type parameter.</typeparam>
    public class GenericClass<T1, T2, T3>
        where T1 : class, IDisposable, new()
        where T2 : struct, ICloneable
        where T3 : ISample, IEqualityComparer<T3>
    {

        /// <summary>
        /// ctor.
        /// </summary>
        public GenericClass()
        {
        }

        /// <summary>
        /// A method that takes the type parameter, <typeparamref name="T1"/> and <typeparamref name="T2"/> and <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <param name="t3">3rd argument.</param>
        public void Action(T1 t1, T2 t2, T3 t3) { }

        /// <summary>
        /// A method that returns the type parameter, <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="t1">1st argument.</param>
        /// <param name="t2">2nd argument.</param>
        /// <returns>Return value.</returns>
        public T3 Func(T1 t1, T2 t2) { return default; }

    }

}
