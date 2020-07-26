



# ClassDocContext Class



A context that manages the state of the output process for class documents.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor](#ctor-constructor) |  |
---
### .ctor Constructor


```c#
public ClassDocContext()
```

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [ConstructorFilter](#constructorfilter-property) | Func&lt;ConstructorInfo, bool&gt; | Gets or sets the method that determines if the specified constructor is an output target. |
| public | [EventFilter](#eventfilter-property) | Func&lt;EventInfo, bool&gt; | Gets or sets the method that determines if the specified event is an output target. |
| public | [FieldFilter](#fieldfilter-property) | Func&lt;FieldInfo, bool&gt; | Gets or sets the method that determines if the specified field is an output target. |
| public | [MethodFilter](#methodfilter-property) | Func&lt;MethodInfo, bool&gt; | Gets or sets the method that determines if the specified method is an output target. |
| public | [PropertyFilter](#propertyfilter-property) | Func&lt;PropertyInfo, bool&gt; | Gets or sets the method that determines if the specified property is an output target. |
| public | [TypeFilter](#typefilter-property) | Func&lt;Type, bool&gt; | Gets or sets the method that determines if the specified type is an output target. |
---
### ConstructorFilter Property

Gets or sets the method that determines if the specified constructor is an output target.
```c#
public Func<ConstructorInfo, bool> ConstructorFilter { get; set; }
```

[Go to properties](#Properties)

---
### EventFilter Property

Gets or sets the method that determines if the specified event is an output target.
```c#
public Func<EventInfo, bool> EventFilter { get; set; }
```

[Go to properties](#Properties)

---
### FieldFilter Property

Gets or sets the method that determines if the specified field is an output target.
```c#
public Func<FieldInfo, bool> FieldFilter { get; set; }
```

[Go to properties](#Properties)

---
### MethodFilter Property

Gets or sets the method that determines if the specified method is an output target.
```c#
public Func<MethodInfo, bool> MethodFilter { get; set; }
```

[Go to properties](#Properties)

---
### PropertyFilter Property

Gets or sets the method that determines if the specified property is an output target.
```c#
public Func<PropertyInfo, bool> PropertyFilter { get; set; }
```

[Go to properties](#Properties)

---
### TypeFilter Property

Gets or sets the method that determines if the specified type is an output target.
```c#
public Func<Type, bool> TypeFilter { get; set; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| public | [GetTypeInfo(Type)](#gettypeinfotype-method) | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) | Gets the specified type of information. If no XML comment is found, returns empty XML comment information. |
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
### GetTypeInfo(Type) Method

Gets the specified type of information. If no XML comment is found, returns empty XML comment information.
```c#
public TypeWithComment GetTypeInfo
(
	Type type
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  | The type. |
#### Return type
The type information.

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



