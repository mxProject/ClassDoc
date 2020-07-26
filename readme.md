# mxProject.Tools.ClassDoc

## Summary

* Reads the XML document comment output from Visual Studio and outputs the document like a class reference.

* The implementation of reading XML document comments and the implementation of document output are separated. You can use the comment information in the read XML document for other purposes.

* This library does not use `SandCastle`.

## Requirement

### mxProject.Tools.ClassDoc

#### Framework
NET Standard 2.0
#### Assemblies
* [ZString 2.1.3](https://github.com/Cysharp/ZString)

### mxProject.Tools.ClassDoc.Razor

#### Framework
NET Framework 4.7.2
#### Assemblies
* mxProject.Tools.ClassDoc
* [RazorEngine 3.0.0.0](https://github.com/Antaris/RazorEngine)


## Features

### Reading XML comment

 Read the information of the following tags described in the type and member, and associate it with the type information and member information obtained by reflection.

* summary
* param
* returns
* paramref
* typeparamref
* exception
* remarks

### inheritdoc

Supports inheritance of comments by &lt;inheritdoc&gt; tag.

```c#
public class BaseClass
{
    /// <summary>
    /// Output to document.
    /// </summary>
    public virtual void OutputDocument() {}
}

public class SubClass : BaseClass
{
    /// <inheritdoc/>
    public override void OutputDocument() {}
}
```

### Reference tag replacement

You can replace &lt;see&gt;, &lt;seealso&gt;, &lt;paramref&gt;, &lt;typeparamref&gt; tags with link strings and more.

Suppose the following tag is described in the XML comment of the source code.
```xml
<see cref="SampleClass"/>
<see cref="SampleClass.SampleMethod"/>
```

This tag is output in the XML comment document as:
```xml
<see cref="T:SampleNamespace.SampleClass"/>
<see cref="M:SampleNamespace.SampleClass.SampleMethod"/>
```

The implementation of the `IClassDocumentFormatter` interface allows you to replace the see tag with a link string like this:
```Markdown
[SampleClass](./SampleNamespace/SampleClass.md)
[SampleClass.SampleMethod](./SampleNamespace/SampleClass.md#SampleMethod)
```

You cannot transition to the anchor of another document. Moves to the top of the document. In the above example, instead of transitioning to the anchor "SampleMethod", it transits to the top of the document "SampleClass .md".


### Output to class document

It is mainly the [IClassDocumentWriter](./Documents/mxProject.Tools.ClassDoc/IClassDocumentWriter.md) interface and [IClassDocumentFormatter](./Documents/mxProject.Tools.ClassDoc/IClassDocumentFormatter.md) interface that are responsible for outputting class documents.

* [RazorDocumentWriter](./Documents/mxProject.Tools.ClassDoc.Razors/RazorDocumentWriter.md) class is an implementation example of `IClassDocumentWriter` interface. Output type information to files using `Razor`. You can customize the output result by rewriting the template file.

* [MarkdownFormatter](./Documents/mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) class is an implementation example of `IClassDocumentFormatter` interface. Output links and anchors in Markdown format.

These linked documents were output by this library.

## Usage

The following code loads the four assemblies contained in the LoadAssemblies folder and outputs the class reference documentation.

In this repository, you can see the templates used and the output documents.

* templates : [RazorTemplates](./RazorTemplates) directory
* output documents : [Documents](./Documents) directory, [DocumentSamples](./DocumentSamples) directory

```c#

static void OutputDocument()
{
    // Razor templates
    string typeTemplate = @".\RazorTemplates\TypeTemplate.txt";
    string namespaceTemplate = @".\RazorTemplates\NamespaceTemplate.txt";

    // Loading assemblies
    string[] dlls = new[]
    {
        @".\LoadAssemblies\mxProject.Tools.ClassDoc.dll",
        @".\LoadAssemblies\mxProject.Tools.ClassDoc.Razor.dll",
        @".\LoadAssemblies\SampleLibrary1.dll",
        @".\LoadAssemblies\SampleLibrary2.dll"
    };

    // Setup a writer.
    RazorDocumentWriter writer = new RazorDocumentWriter(Encoding.UTF8)
    {
        RootDirectory = @".\Documents\",
        TypeDocumentTemplate = File.ReadAllText(typeTemplate, Encoding.UTF8),
        NamespaceDocumentTemplate = File.ReadAllText(namespaceTemplate, Encoding.UTF8),
    };

    // Setup a context and a formatter.
    ClassDocContext context = new ClassDocContext()
    {
        // note: These values are the same as those set in the initial value of ClassDocContext.
        ConstructorFilter = ConstructorInfoExtensions.IsRecommendOutputToDocument,
        TypeFilter = TypeExtenstions.IsRecommendOutputToDocument,
        PropertyFilter = PropertyInfoExtensions.IsRecommendOutputToDocument,
        FieldFilter = FieldInfoExtensions.IsRecommendOutputToDocument,
        MethodFilter = MethodInfoExtensions.IsRecommendOutputToDocument,
        EventFilter = EventInfoExtensions.IsRecommendOutputToDocument,
    };

    MarkdownFormatter formatter = new MarkdownFormatter(context)
    {
        // note: These values are the same as those set in the initial value of MarkdownFormatter.
        ConstructorAnchorDefaultFormat = "{0} Constructor",
        PropertyAnchorDefaultFormat = "{0} Property",
        FieldAnchorDefaultFormat = "{0} Field",
        MethodAnchorDefaultFormat = "{0} Method",
        EventAnchorDefaultFormat = "{0} Event",
        ParameterNameDefaultFormat = "`{0}`",
    };

    // Load type information.
    IReadOnlyList<TypeWithComment> types = TypeLoader.LoadTypes(dlls, context, null);

    // Group by namespace.
    foreach (var group in types.GroupBy(type => type.Namespace).OrderBy(group => group.Key))
    {
        NamespaceInfo nameSpace = new NamespaceInfo(group.First()?.Namespace, group);

        // Output the document for the namespace.
        writer.WriteNamespaceDocument(nameSpace, formatter);

        // Output the document for the type.
        foreach (var type in group.OrderBy(type => type.Name))
        {
            writer.WriteTypeDocument(type, formatter);
        }
    }
}
```

## License

[MIT Licence](https://opensource.org/licenses/mit-license.php)
