



# ParameterInfoWithComment Class



parameter information and its XML comment.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(ParameterInfo, Func&lt;ParameterComment&gt;, ClassDocContext)](#ctorparameterinfo-funcparametercomment-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(ParameterInfo, Func&lt;ParameterComment&gt;, ClassDocContext) Constructor

Create a new instance.
```c#
public ParameterInfoWithComment(
	ParameterInfo parameter
	, Func<ParameterComment> commentGetter
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| parameter | ParameterInfo | The parameter information. |
| commentGetter | Func&lt;ParameterComment&gt; | The method to get comment of parameter. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [ParameterComment](../mxProject.Tools.ClassDoc/ParameterComment.md) | Gets the XML comment. |
| public | [Info](#info-property) | ParameterInfo | Gets the parameter information. |
| public | [IO](#io-property) | string | Gets the direction of the parameter. |
| public | [Name](#name-property) | string | Gets the name. |
| public | [ParameterTypeInfo](#parametertypeinfo-property) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Get the type information of the parameter. |
---
### Comment Property

Gets the XML comment.
```c#
public ParameterComment Comment { get; }
```

[Go to properties](#Properties)

---
### Info Property

Gets the parameter information.
```c#
public ParameterInfo Info { get; }
```

[Go to properties](#Properties)

---
### IO Property

Gets the direction of the parameter.
```c#
public string IO { get; }
```

[Go to properties](#Properties)

---
### Name Property

Gets the name.
```c#
public string Name { get; }
```

[Go to properties](#Properties)

---
### ParameterTypeInfo Property

Get the type information of the parameter.
```c#
public TypeWithComment ParameterTypeInfo { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDescription(string)](#getdescriptionstring-method) | string | Get the description. |
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
### GetDescription(string) Method

Get the description.
```c#
public string GetDescription
(
	string delimiter = " "
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| delimiter | string |  | The delimiter when multiple descriptions are listed. |
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



