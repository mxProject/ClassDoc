using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Sample action.
    /// </summary>
    /// <param name="sample">sample instance.</param>
    public delegate void SampleAction(SampleClass sample);

    /// <summary>
    /// Sample function.
    /// </summary>
    /// <param name="sample">sample instance.</param>
    /// <returns>A return value.</returns>
    public delegate object SampleFunc(SampleClass sample);

    /// <summary>
    /// Sample generic action.
    /// </summary>
    /// <typeparam name="TSample">The type of the sample instance.</typeparam>
    /// <param name="sample">sample instance.</param>
    public delegate void SampleGenericAction<TSample>(TSample sample) where TSample : ISample;

    /// <summary>
    /// Sample generic function.
    /// </summary>
    /// <typeparam name="TSample">The type of the sample instance.</typeparam>
    /// <typeparam name="TResult">The type of return value.</typeparam>
    /// <param name="sample">sample instance.</param>
    /// <returns>A return value.</returns>
    public delegate TResult SampleGenericFunc<TSample, TResult>(TSample sample) where TSample : ISample;

}
