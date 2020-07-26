



# MemberInfoWithComment&lt;TInfo&gt; Class



Member information and its XML comment.







## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| TInfo |  | MemberInfo |

## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| protected | [.ctor(TInfo, XmlComment, ClassDocContext)](#ctortinfo-xmlcomment-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(TInfo, XmlComment, ClassDocContext) Constructor

Create a new instance.
```c#
protected MemberInfoWithComment(
	TInfo member
	, XmlComment comment
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| member | TInfo | The member information. |
| comment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | The XML comment. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Gets the XML comment. |
| public | [Info](#info-property) | TInfo | Gets the member information. |
| public | [InheritComment](#inheritcomment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Gets the inherited XML comment. |
| public | [IsObsolete](#isobsolete-property) | bool | Gets whether it is obsolete. |
| public | [Name](#name-property) | string | Gets the member name. |
| public | [Scope](#scope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
---
### Comment Property

Gets the XML comment.
```c#
public XmlComment Comment { get; }
```

[Go to properties](#Properties)

---
### Info Property

Gets the member information.
```c#
public TInfo Info { get; }
```

[Go to properties](#Properties)

---
### InheritComment Property

Gets the inherited XML comment.
```c#
public XmlComment InheritComment { get; }
```

[Go to properties](#Properties)

---
### IsObsolete Property

Gets whether it is obsolete.
```c#
public bool IsObsolete { get; }
```

[Go to properties](#Properties)

---
### Name Property

Gets the member name.
```c#
public string Name { get; }
```

[Go to properties](#Properties)

---
### Scope Property

Gets the scope.
```c#
public MemberScope Scope { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| protected | [CreateParameterList(ParameterInfo[])](#createparameterlistparameterinfo-method) | List&lt;ParameterInfoWithComment&gt; | Creates a list that stores information for the specified parameters. |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDeclaringTypeInfo](#getdeclaringtypeinfo-method) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Gets information of the type for which this member is declared. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| protected | [GetInheritComment](#getinheritcomment-method) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Gets the inherited XML comment. |
| protected | [GetMemberScope](#getmemberscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
| protected | [GetSummaryWithInherits(XmlComment)](#getsummarywithinheritsxmlcomment-method) | string | Gets the summary. Add the content about inheritance. |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### CreateParameterList(ParameterInfo[]) Method

Creates a list that stores information for the specified parameters.
```c#
protected List<ParameterInfoWithComment> CreateParameterList
(
	ParameterInfo[] parameters
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| parameters | ParameterInfo[] |  | The parameters. |
#### Return type


[Go to methods](#Methods)

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
### GetDeclaringTypeInfo Method

Gets information of the type for which this member is declared.
```c#
public TypeWithComment GetDeclaringTypeInfo()
```
#### Return type


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
### GetInheritComment Method

Gets the inherited XML comment.
```c#
protected abstract XmlComment GetInheritComment()
```
#### Return type


[Go to methods](#Methods)

---
### GetMemberScope Method

Gets the scope.
```c#
protected abstract MemberScope GetMemberScope()
```
#### Return type
The scope.

[Go to methods](#Methods)

---
### GetSummaryWithInherits(XmlComment) Method

Gets the summary. Add the content about inheritance.
```c#
protected string GetSummaryWithInherits
(
	XmlComment inheritComment
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| inheritComment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) |  | The inherited XML comment. |
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



