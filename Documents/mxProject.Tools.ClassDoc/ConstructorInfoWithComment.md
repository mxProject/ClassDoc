



# ConstructorInfoWithComment Class



Constructor information and its XML comment.








## Inheritance tree
* mxProject.Tools.ClassDoc.MemberInfoWithComment&lt;ConstructorInfo&gt;
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(ConstructorInfo, XmlComment, ClassDocContext)](#ctorconstructorinfo-xmlcomment-classdoccontext-constructor) | Creates a new instance. |
---
### .ctor(ConstructorInfo, XmlComment, ClassDocContext) Constructor

Creates a new instance.
```c#
public ConstructorInfoWithComment(
	ConstructorInfo ctor
	, XmlComment comment
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| ctor | ConstructorInfo | The constructor information. |
| comment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | The XML comment. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [Declaretion](#declaretion-property) | string | Gets the declaretion statement. |
| public | [Info](#info-property) | ConstructorInfo | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [InheritComment](#inheritcomment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [IsObsolete](#isobsolete-property) | bool | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [Name](#name-property) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [Parameters](#parameters-property) | IReadOnlyList&lt;ParameterInfoWithComment&gt; | Gets the parameters. |
| public | [Scope](#scope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
---
### Comment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
public XmlComment Comment { get; }
```

[Go to properties](#Properties)

---
### Declaretion Property

Gets the declaretion statement.
```c#
public string Declaretion { get; }
```

[Go to properties](#Properties)

---
### Info Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
public ConstructorInfo Info { get; }
```

[Go to properties](#Properties)

---
### InheritComment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
public XmlComment InheritComment { get; }
```

[Go to properties](#Properties)

---
### IsObsolete Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
public bool IsObsolete { get; }
```

[Go to properties](#Properties)

---
### Name Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
public string Name { get; }
```

[Go to properties](#Properties)

---
### Parameters Property

Gets the parameters.
```c#
public IReadOnlyList<ParameterInfoWithComment> Parameters { get; }
```

[Go to properties](#Properties)

---
### Scope Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
public MemberScope Scope { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| protected | [CreateParameterList(ParameterInfo[])](#createparameterlistparameterinfo-method) | List&lt;ParameterInfoWithComment&gt; | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDeclaringTypeInfo](#getdeclaringtypeinfo-method) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| protected | [GetInheritComment](#getinheritcomment-method) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) . |
| protected | [GetMemberScope](#getmemberscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
| protected | [GetSummaryWithInherits(XmlComment)](#getsummarywithinheritsxmlcomment-method) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### CreateParameterList(ParameterInfo[]) Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
protected List<ParameterInfoWithComment> CreateParameterList
(
	ParameterInfo[] parameters
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| parameters | ParameterInfo[] |  |  |
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

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
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

Inherited from  [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) .
```c#
protected virtual XmlComment GetInheritComment()
```

This class always returns null.

#### Return type


[Go to methods](#Methods)

---
### GetMemberScope Method

Gets the scope.
```c#
protected virtual MemberScope GetMemberScope()
```
#### Return type
The scope.

[Go to methods](#Methods)

---
### GetSummaryWithInherits(XmlComment) Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.ConstructorInfo} .
```c#
protected string GetSummaryWithInherits
(
	XmlComment inheritComment
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| inheritComment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) |  |  |
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



