



# EventInfoWithComment Class



Event information and its XML comment.








## Inheritance tree
* mxProject.Tools.ClassDoc.MemberInfoWithComment&lt;EventInfo&gt;
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(EventInfo, XmlComment, ClassDocContext)](#ctoreventinfo-xmlcomment-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(EventInfo, XmlComment, ClassDocContext) Constructor

Create a new instance.
```c#
public EventInfoWithComment(
	EventInfo evt
	, XmlComment comment
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| evt | EventInfo | The field information. |
| comment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | The XML comment. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [EventHandlerTypeInfo](#eventhandlertypeinfo-property) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Get the type information of the event handler. |
| public | [Info](#info-property) | EventInfo | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [InheritComment](#inheritcomment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [IsObsolete](#isobsolete-property) | bool | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [IsStatic](#isstatic-property) | bool | Gets a value indicating whether the event is static. |
| public | [Name](#name-property) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [Scope](#scope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
---
### Comment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
```c#
public XmlComment Comment { get; }
```

[Go to properties](#Properties)

---
### EventHandlerTypeInfo Property

Get the type information of the event handler.
```c#
public TypeWithComment EventHandlerTypeInfo { get; }
```

[Go to properties](#Properties)

---
### Info Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
```c#
public EventInfo Info { get; }
```

[Go to properties](#Properties)

---
### InheritComment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
```c#
public XmlComment InheritComment { get; }
```

[Go to properties](#Properties)

---
### IsObsolete Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
```c#
public bool IsObsolete { get; }
```

[Go to properties](#Properties)

---
### IsStatic Property

Gets a value indicating whether the event is static.
```c#
public bool IsStatic { get; }
```

[Go to properties](#Properties)

---
### Name Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
```c#
public string Name { get; }
```

[Go to properties](#Properties)

---
### Scope Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
```c#
public MemberScope Scope { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| protected | [CreateParameterList(ParameterInfo[])](#createparameterlistparameterinfo-method) | List&lt;ParameterInfoWithComment&gt; | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetAddMethodScope](#getaddmethodscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of AddMethod. |
| public | [GetDeclaringTypeInfo](#getdeclaringtypeinfo-method) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| protected | [GetInheritComment](#getinheritcomment-method) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  [EventInfoWithComment](../mxProject.Tools.ClassDoc/EventInfoWithComment.md) . |
| protected | [GetMemberScope](#getmemberscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. If AddMethod and RemoveMethod and RaizeMethod have different scopes, the wider scope is returned. |
| public | [GetRaiseMethodScope](#getraisemethodscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of RaizeMethod. |
| public | [GetRemoveMethodScope](#getremovemethodscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of RemoveMethod. |
| public | [GetSummaryWithInherits](#getsummarywithinherits-method) | string | Gets the summary. Add the content about inheritance. |
| protected | [GetSummaryWithInherits(XmlComment)](#getsummarywithinheritsxmlcomment-method) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### CreateParameterList(ParameterInfo[]) Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
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
### GetAddMethodScope Method

Gets the scope of AddMethod.
```c#
public MemberScope GetAddMethodScope()
```
#### Return type
The scope.

[Go to methods](#Methods)

---
### GetDeclaringTypeInfo Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
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

Inherited from  [EventInfoWithComment](../mxProject.Tools.ClassDoc/EventInfoWithComment.md) .
```c#
protected virtual XmlComment GetInheritComment()
```
#### Return type


[Go to methods](#Methods)

---
### GetMemberScope Method

Gets the scope. If AddMethod and RemoveMethod and RaizeMethod have different scopes, the wider scope is returned.
```c#
protected virtual MemberScope GetMemberScope()
```
#### Return type
The scope.

[Go to methods](#Methods)

---
### GetRaiseMethodScope Method

Gets the scope of RaizeMethod.
```c#
public MemberScope GetRaiseMethodScope()
```
#### Return type
The scope.

[Go to methods](#Methods)

---
### GetRemoveMethodScope Method

Gets the scope of RemoveMethod.
```c#
public MemberScope GetRemoveMethodScope()
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

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.EventInfo} .
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



