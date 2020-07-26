



# TypeParameterWithComment Class



Type parameter and its XML comment.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(Type, Func&lt;ParameterComment&gt;, ClassDocContext)](#ctortype-funcparametercomment-classdoccontext-constructor) | Creates a new instance. |
---
### .ctor(Type, Func&lt;ParameterComment&gt;, ClassDocContext) Constructor

Creates a new instance.
```c#
public TypeParameterWithComment(
	Type parameterType
	, Func<ParameterComment> commentGetter
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| parameterType | Type | The generic parameter type. |
| commentGetter | Func&lt;ParameterComment&gt; | The method to get comment of parameter. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Attributes](#attributes-property) | GenericParameterAttributes | Gets the parameter attributes. |
| public | [Comment](#comment-property) | [ParameterComment](../mxProject.Tools.ClassDoc/ParameterComment.md) | Gets the XML comment. |
| public | [Name](#name-property) | string | Gets the name. |
| public | [ParameterType](#parametertype-property) | Type | Gets the generic parameter type. |
---
### Attributes Property

Gets the parameter attributes.
```c#
public GenericParameterAttributes Attributes { get; }
```

[Go to properties](#Properties)

---
### Comment Property

Gets the XML comment.
```c#
public ParameterComment Comment { get; }
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
### ParameterType Property

Gets the generic parameter type.
```c#
public Type ParameterType { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetConstraintTypes](#getconstrainttypes-method) | TypeWithComment[] | Gets the constraint types. |
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
### GetConstraintTypes Method

Gets the constraint types.
```c#
public TypeWithComment[] GetConstraintTypes()
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



