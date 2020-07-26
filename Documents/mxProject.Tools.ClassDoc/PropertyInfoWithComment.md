



# PropertyInfoWithComment Class



Property information and its XML comment.








## Inheritance tree
* mxProject.Tools.ClassDoc.MemberInfoWithComment&lt;PropertyInfo&gt;
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(PropertyInfo, XmlComment, ClassDocContext)](#ctorpropertyinfo-xmlcomment-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(PropertyInfo, XmlComment, ClassDocContext) Constructor

Create a new instance.
```c#
public PropertyInfoWithComment(
	PropertyInfo prop
	, XmlComment comment
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| prop | PropertyInfo | The property information. |
| comment | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | The XML comment. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [Declaretion](#declaretion-property) | string | Gets the declaretion statement. |
| public | [GetterScope](#getterscope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of the get accessor. |
| public | [Info](#info-property) | PropertyInfo | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [InheritComment](#inheritcomment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [IsObsolete](#isobsolete-property) | bool | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [IsStatic](#isstatic-property) | bool | Gets a value indicating whether the property is static. |
| public | [Name](#name-property) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [Parameters](#parameters-property) | IReadOnlyList&lt;ParameterInfoWithComment&gt; | Gets the parameters. |
| public | [PropertyTypeInfo](#propertytypeinfo-property) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Get the type information of the property. |
| public | [Scope](#scope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [SetterScope](#setterscope-property) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of the set accessor. |
---
### Comment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
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
### GetterScope Property

Gets the scope of the get accessor.
```c#
public MemberScope GetterScope { get; }
```

[Go to properties](#Properties)

---
### Info Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
```c#
public PropertyInfo Info { get; }
```

[Go to properties](#Properties)

---
### InheritComment Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
```c#
public XmlComment InheritComment { get; }
```

[Go to properties](#Properties)

---
### IsObsolete Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
```c#
public bool IsObsolete { get; }
```

[Go to properties](#Properties)

---
### IsStatic Property

Gets a value indicating whether the property is static.
```c#
public bool IsStatic { get; }
```

[Go to properties](#Properties)

---
### Name Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
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
### PropertyTypeInfo Property

Get the type information of the property.
```c#
public TypeWithComment PropertyTypeInfo { get; }
```

[Go to properties](#Properties)

---
### Scope Property

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
```c#
public MemberScope Scope { get; }
```

[Go to properties](#Properties)

---
### SetterScope Property

Gets the scope of the set accessor.
```c#
public MemberScope SetterScope { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| protected | [CreateParameterList(ParameterInfo[])](#createparameterlistparameterinfo-method) | List&lt;ParameterInfoWithComment&gt; | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDeclaringTypeInfo](#getdeclaringtypeinfo-method) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| protected | [GetInheritComment](#getinheritcomment-method) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Gets the inherited XML comment. |
| protected | [GetMemberScope](#getmemberscope-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. If the getter and the setter have different scopes, the wider scope is returned. |
| public | [GetSummaryWithInherits](#getsummarywithinherits-method) | string | Gets the summary. Add the content about inheritance. |
| protected | [GetSummaryWithInherits(XmlComment)](#getsummarywithinheritsxmlcomment-method) | string | Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### CreateParameterList(ParameterInfo[]) Method

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
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

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
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

Gets the scope. If the getter and the setter have different scopes, the wider scope is returned.
```c#
protected virtual MemberScope GetMemberScope()
```
#### Return type


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

Inherited from  mxProject.Tools.ClassDoc.MemberInfoWithComment{System.Reflection.PropertyInfo} .
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



