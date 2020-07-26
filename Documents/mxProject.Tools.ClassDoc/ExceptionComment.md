



# ExceptionComment Class



Comment about the exception.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(string, string[], ClassDocContext)](#ctorstring-string-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(string, string[], ClassDocContext) Constructor

Create a new instance.
```c#
public ExceptionComment(
	string exceptionTypeSignature
	, string[] descriptions
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| exceptionTypeSignature | string | The exception type signature. |
| descriptions | string[] | The descriptions. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Descriptions](#descriptions-property) | IReadOnlyList&lt;string&gt; | Gets the description. |
| public | [ExceptionTypeInfo](#exceptiontypeinfo-property) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Gets the exception type information. Returns null if the type cannot be obtained from the comment signature. |
| public | [ExceptionTypeSignature](#exceptiontypesignature-property) | [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) | Gets the exception type signature. |
| public | [ExceptionTypeSignatureName](#exceptiontypesignaturename-property) | string | Gets the exception type signature. |
---
### Descriptions Property

Gets the description.
```c#
public IReadOnlyList<string> Descriptions { get; }
```

[Go to properties](#Properties)

---
### ExceptionTypeInfo Property

Gets the exception type information. Returns null if the type cannot be obtained from the comment signature.
```c#
public TypeWithComment ExceptionTypeInfo { get; }
```

[Go to properties](#Properties)

---
### ExceptionTypeSignature Property

Gets the exception type signature.
```c#
public XmlCommentSignature ExceptionTypeSignature { get; }
```

[Go to properties](#Properties)

---
### ExceptionTypeSignatureName Property

Gets the exception type signature.
```c#
public string ExceptionTypeSignatureName { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDescriptions(string)](#getdescriptionsstring-method) | string | Gets the description. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
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
### GetDescriptions(string) Method

Gets the description.
```c#
public string GetDescriptions
(
	string delimiter = " "
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| delimiter | string |  | The delimiter when multiple descriptions are listed. |
#### Return type
The description.

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
### ToString Method

Inherited from  System.Object .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)



