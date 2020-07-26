



# MethodInfoWithComment Class



Method information and its XML comment.








## Inheritance tree
* mxProject.Tools.ClassDoc.MemberInfoWithComment&lt;MethodInfo&gt;
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(MethodInfo, XmlComment, ClassDocContext)](#ctormethodinfo-xmlcomment-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(MethodInfo, XmlComment, ClassDocContext) Constructor

Create a new instance.
```c#
public MethodInfoWithComment(
	MethodInfo method
	, XmlComment comment
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| method | MethodInfo | The method information. |
| comment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | The XML comment. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [Declaretion](#declaretion-property) | string | Gets the declaretion statement. |
| public | [GenericParameterTypes](#genericparametertypes-property) | IReadOnlyList&lt;TypeParameterWithComment&gt; | Gets the generic parameters. |
| public | [HasReturnValue](#hasreturnvalue-property) | bool | Gets whether the method returns a return value. |
| public | [Info](#info-property) | MethodInfo | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [InheritComment](#inheritcomment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [IsGenericMethodDefinition](#isgenericmethoddefinition-property) | bool | Gets a value indicating whether this method represents a generic method definition. |
| public | [IsObsolete](#isobsolete-property) | bool | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [IsStatic](#isstatic-property) | bool | Gets a value indicating whether the method is static. |
| public | [Name](#name-property) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [Parameters](#parameters-property) | IReadOnlyList&lt;ParameterInfoWithComment&gt; | Gets the parameters. |
| public | [ReturnTypeInfo](#returntypeinfo-property) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Get the type information of the return value. |
| public | [Scope](#scope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
---
### Comment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
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
### GenericParameterTypes Property

Gets the generic parameters.
```c#
public IReadOnlyList<TypeParameterWithComment> GenericParameterTypes { get; }
```

[Go to properties](#Properties)

---
### HasReturnValue Property

Gets whether the method returns a return value.
```c#
public bool HasReturnValue { get; }
```

[Go to properties](#Properties)

---
### Info Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
```c#
public MethodInfo Info { get; }
```

[Go to properties](#Properties)

---
### InheritComment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
```c#
public XmlComment InheritComment { get; }
```

[Go to properties](#Properties)

---
### IsGenericMethodDefinition Property

Gets a value indicating whether this method represents a generic method definition.
```c#
public bool IsGenericMethodDefinition { get; }
```

[Go to properties](#Properties)

---
### IsObsolete Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
```c#
public bool IsObsolete { get; }
```

[Go to properties](#Properties)

---
### IsStatic Property

Gets a value indicating whether the method is static.
```c#
public bool IsStatic { get; }
```

[Go to properties](#Properties)

---
### Name Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
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
### ReturnTypeInfo Property

Get the type information of the return value.
```c#
public TypeWithComment ReturnTypeInfo { get; }
```

[Go to properties](#Properties)

---
### Scope Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
```c#
public MemberScope Scope { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| protected | [CreateParameterList(ParameterInfo[])](#createparameterlistparameterinfo-method) | List&lt;ParameterInfoWithComment&gt; | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDeclaringTypeInfo](#getdeclaringtypeinfo-method) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| protected | [GetInheritComment](#getinheritcomment-method) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Gets the inherited XML comment. |
| protected | [GetMemberScope](#getmemberscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
| public | [GetSummaryWithInherits](#getsummarywithinherits-method) | string | Gets the summary. Add the content about inheritance. |
| protected | [GetSummaryWithInherits(XmlComment)](#getsummarywithinheritsxmlcomment-method) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### CreateParameterList(ParameterInfo[]) Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
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

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
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
protected virtual XmlComment GetInheritComment()
```
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
### GetSummaryWithInherits Method

Gets the summary. Add the content about inheritance.
```c#
public string GetSummaryWithInherits()
```
#### Return type


[Go to methods](#Methods)

---
### GetSummaryWithInherits(XmlComment) Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.MethodInfo} .
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



