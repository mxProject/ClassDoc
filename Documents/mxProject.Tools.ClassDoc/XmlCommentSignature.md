



# XmlCommentSignature ValueType



XML comment signature.








## Inheritance tree
* System.ValueType
* System.Object
## Implemented interfaces
* System.IEquatable&lt;XmlCommentSignature&gt;

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(XmlCommentKind, string, string, string)](#ctorxmlcommentkind-string-string-string-constructor) | Create a new instance/ |
---
### .ctor(XmlCommentKind, string, string, string) Constructor

Create a new instance/
```c#
public XmlCommentSignature(
	XmlCommentKind kind
	, string typeName
	, string memberName
	, string methodArguments
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| kind | [XmlCommentKind](../mxProject.Tools.ClassDoc/XmlCommentKind.md) | The kind. |
| typeName | string | The type name. |
| memberName | string | The member name. |
| methodArguments | string | The method arguments. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Kind](#kind-property) | [XmlCommentKind](../mxProject.Tools.ClassDoc/XmlCommentKind.md) | Gets the kind. |
| public | [MemberName](#membername-property) | string | Gets the member name. |
| public | [MethodArguments](#methodarguments-property) | string | Gets the method arguments. |
| public | [TypeName](#typename-property) | string | Gets the type name. |
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
### TypeName Property

Gets the type name.
```c#
public string TypeName { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) . |
| public | [Equals(XmlCommentSignature)](#equalsxmlcommentsignature-method) | bool | Inherited from  [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.ValueType . |
---
### Equals(object) Method

Inherited from  [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) .
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
### Equals(XmlCommentSignature) Method

Inherited from  [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) .
```c#
public virtual bool Equals
(
	XmlCommentSignature other
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| other | [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) |  |  |
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

Inherited from  [XmlCommentSignature](../mxProject.Tools.ClassDoc/XmlCommentSignature.md) .
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

Inherited from  System.ValueType .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)



