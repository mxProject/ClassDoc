using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleLibrary
{

    /// <summary>
    /// XML comment sample.
    /// </summary>
    /// <typeparam name="TItem">The type of the value.</typeparam>
    /// <remarks>
    /// <para>
    /// First paragraph of remarks.
    /// </para>
    /// <para>
    /// Second paragraph of remarks.
    /// </para>
    /// <para>
    /// Link to type : <see cref="SampleClass"/>
    /// </para>
    /// <para>
    /// Link to type : <see cref="SampleClass">see SampleClass</see>
    /// </para>
    /// <para>
    /// Link to type : <seealso cref="SampleSubClass"/>
    /// </para>
    /// <para>
    /// Link to type : <seealso cref="SampleSubClass">seealso SampleSubClass</seealso>
    /// </para>
    /// <para>
    /// Link to method : <see cref="SampleClass.Action(byte)"/>
    /// </para>
    /// <para>
    /// Link to method : <see cref="SampleClass.Action(byte)">see SampleClass.Action</see>
    /// </para>
    /// <para>
    /// Link to method : <seealso cref="SampleSubClass.SubClassAction(long)"/>
    /// </para>
    /// <para>
    /// Link to method : <seealso cref="SampleSubClass.SubClassAction(long)">seealso SampleSubClass.SubClassAction</seealso>
    /// </para>
    /// <para>
    /// Link to property : <see cref="SampleClass.Property"/>
    /// </para>
    /// <para>
    /// Link to property : <see cref="SampleClass.Property">see SampleClass.Property</see>
    /// </para>
    /// <para>
    /// Link to property : <seealso cref="SampleSubClass.SubClassProperty"/>
    /// </para>
    /// <para>
    /// Link to property : <seealso cref="SampleSubClass.SubClassProperty">seealso SampleSubClass.SubClassProperty</seealso>
    /// </para>
    /// <para>
    /// Link to field : <see cref="SampleClass.Field"/>
    /// </para>
    /// <para>
    /// Link to field : <see cref="SampleClass.Field">see SampleClass.Field</see>
    /// </para>
    /// <para>
    /// Link to field : <seealso cref="SampleSubClass.SubClassField"/>
    /// </para>
    /// <para>
    /// Link to field : <seealso cref="SampleSubClass.SubClassField">seealso SampleSubClass.SubClassField</seealso>
    /// </para>
    /// <para>
    /// Link to event : <see cref="SampleClass.Event"/>
    /// </para>
    /// <para>
    /// Link to event : <see cref="SampleClass.Event">see SampleClass.Event</see>
    /// </para>
    /// <para>
    /// Link to event : <seealso cref="SampleSubClass.SubClassEvent"/>
    /// </para>
    /// <para>
    /// Link to event : <seealso cref="SampleSubClass.SubClassEvent">seealso SampleSubClass.SubClassEvent</seealso>
    /// </para>
    /// </remarks>
    public class CommentSample<TItem>
    {

        /// <summary>
        /// Gets the value corresponding to the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>A value corresponding to the specified name.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="name"/> is null.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This instance is already disposed.
        /// </exception>
        public TItem GetValue(string name) { return default; }

        /// <summary>
        /// Gets the value corresponding to the specified name.
        /// </summary>
        /// <typeparam name="TResult">The type of converted value.</typeparam>
        /// <param name="name">The name.</param>
        /// <param name="converter">The value converter.</param>
        /// <returns>A converted value.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="name"/> is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="converter"/> is null.
        /// </exception>
        public TResult GetConvertedValue<TResult>(string name, Converter<TItem, TResult> converter) { return default; }

    }
}
