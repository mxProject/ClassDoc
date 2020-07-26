



# XmlComment Class



XML comment.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Fields](#Fields)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(ClassDocContext)](#ctorclassdoccontext-constructor) | Create a new instance. |
---
### .ctor(ClassDocContext) Constructor

Create a new instance.
```c#
public XmlComment(
	ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Exceptions](#exceptions-property) | IReadOnlyList&lt;ExceptionComment&gt; | Gets the exceptions. |
| public | [IsEmpty](#isempty-property) | bool | Gets whether it is an empty instance. |
| public | [IsInherit](#isinherit-property) | bool | Gets whether to inherit the comment of the inheritance source. |
| public | [Kind](#kind-property) | [XmlCommentKind](../mxProject.Tools.ClassDoc/XmlCommentKind.md) | Gets the kind. |
| public | [MemberName](#membername-property) | string | Gets the member name. |
| public | [MethodArguments](#methodarguments-property) | string | Gets the method arguments. |
| public | [Parameters](#parameters-property) | IReadOnlyDictionary&lt;string, ParameterComment&gt; | Gets the parameters. |
| public | [Remarks](#remarks-property) | string | Gets the remarks. |
| public | [Returns](#returns-property) | string | Gets the return value. |
| public | [Signature](#signature-property) | [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) | Gets the parsed signature. |
| public | [SignatureName](#signaturename-property) | string | Gets the signature. |
| public | [Summary](#summary-property) | string | Gets the summary. |
| public | [TypeName](#typename-property) | string | Gets the type name. |
| public | [TypeParameters](#typeparameters-property) | IReadOnlyDictionary&lt;string, ParameterComment&gt; | Gets the type parameters. |
---
### Exceptions Property

Gets the exceptions.
```c#
public IReadOnlyList<ExceptionComment> Exceptions { get; }
```

[Go to properties](#Properties)

---
### IsEmpty Property

Gets whether it is an empty instance.
```c#
public bool IsEmpty { get; }
```

[Go to properties](#Properties)

---
### IsInherit Property

Gets whether to inherit the comment of the inheritance source.
```c#
public bool IsInherit { get; internal set; }
```

[Go to properties](#Properties)

---
### Kind Property

Gets the kind.
```c#
public XmlCommentKind Kind { get; }
```

[Go to properties](#Properties)

---
### MemberName Property

Gets the member name.
```c#
public string MemberName { get; }
```

[Go to properties](#Properties)

---
### MethodArguments Property

Gets the method arguments.
```c#
public string MethodArguments { get; }
```

[Go to properties](#Properties)

---
### Parameters Property

Gets the parameters.
```c#
public IReadOnlyDictionary<string, ParameterComment> Parameters { get; }
```

[Go to properties](#Properties)

---
### Remarks Property

Gets the remarks.
```c#
public string Remarks { get; internal set; }
```

[Go to properties](#Properties)

---
### Returns Property

Gets the return value.
```c#
public string Returns { get; internal set; }
```

[Go to properties](#Properties)

---
### Signature Property

Gets the parsed signature.
```c#
public XmlCommentSignature Signature { get; internal set; }
```

[Go to properties](#Properties)

---
### SignatureName Property

Gets the signature.
```c#
public string SignatureName { get; internal set; }
```

[Go to properties](#Properties)

---
### Summary Property

Gets the summary.
```c#
public string Summary { get; internal set; }
```

[Go to properties](#Properties)

---
### TypeName Property

Gets the type name.
```c#
public string TypeName { get; }
```

[Go to properties](#Properties)

---
### TypeParameters Property

Gets the type parameters.
```c#
public IReadOnlyDictionary<string, ParameterComment> TypeParameters { get; }
```

[Go to properties](#Properties)


---
## Static Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| public | [Empty](#empty-field) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Empty instance. |
---
### Empty Field

Empty instance.

[Go to fields](#Fields)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [RemarkLines](#remarklines-method) | IEnumerable&lt;string&gt; | Enumerates remarks by line. |
| public | [ToString](#tostring-method) | string | Inherited from  [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) . |
---
### Equals(object) Method

Inherited from  System.Object .
```c#
public virtual bool Equals
(
	object obj
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| obj | object |  |  |
#### Return type


[Go to methods](#Methods)

---
### Finalize Method

Inherited from  System.Object .
```c#
protected virtual void Finalize()
```

[Go to methods](#Methods)

---
### GetHashCode Method

Inherited from  System.Object .
```c#
public virtual int GetHashCode()
```
#### Return type


[Go to methods](#Methods)

---
### GetType Method

Inherited from  System.Object .
```c#
public Type GetType()
```
#### Return type


[Go to methods](#Methods)

---
### MemberwiseClone Method

Inherited from  System.Object .
```c#
protected object MemberwiseClone()
```
#### Return type


[Go to methods](#Methods)

---
### RemarkLines Method

Enumerates remarks by line.
```c#
public IEnumerable<string> RemarkLines()
```
#### Return type


[Go to methods](#Methods)

---
### ToString Method

Inherited from  [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)



