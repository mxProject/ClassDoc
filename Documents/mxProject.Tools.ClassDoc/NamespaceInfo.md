



# NamespaceInfo Class



Namespace information.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(string, IEnumerable&lt;TypeWithComment&gt;)](#ctorstring-ienumerabletypewithcomment-constructor) | Create a new instance. |
---
### .ctor(string, IEnumerable&lt;TypeWithComment&gt;) Constructor

Create a new instance.
```c#
public NamespaceInfo(
	string nameSpace
	, IEnumerable<TypeWithComment> types
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| nameSpace | string | The namespace. |
| types | IEnumerable&lt;TypeWithComment&gt; | The types defined in the namespace. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Classes](#classes-property) | IReadOnlyList&lt;TypeWithComment&gt; | Gets the class list. |
| public | [Delegates](#delegates-property) | IReadOnlyList&lt;TypeWithComment&gt; | Gets the delegate list. |
| public | [Enums](#enums-property) | IReadOnlyList&lt;TypeWithComment&gt; | Gets the enum list. |
| public | [Interfaces](#interfaces-property) | IReadOnlyList&lt;TypeWithComment&gt; | Gets the interface list. |
| public | [Namespace](#namespace-property) | string | Gets the namespace. |
| public | [ValueTypes](#valuetypes-property) | IReadOnlyList&lt;TypeWithComment&gt; | Gets the valueType list. |
---
### Classes Property

Gets the class list.
```c#
public IReadOnlyList<TypeWithComment> Classes { get; }
```

[Go to properties](#Properties)

---
### Delegates Property

Gets the delegate list.
```c#
public IReadOnlyList<TypeWithComment> Delegates { get; }
```

[Go to properties](#Properties)

---
### Enums Property

Gets the enum list.
```c#
public IReadOnlyList<TypeWithComment> Enums { get; }
```

[Go to properties](#Properties)

---
### Interfaces Property

Gets the interface list.
```c#
public IReadOnlyList<TypeWithComment> Interfaces { get; }
```

[Go to properties](#Properties)

---
### Namespace Property

Gets the namespace.
```c#
public string Namespace { get; }
```

[Go to properties](#Properties)

---
### ValueTypes Property

Gets the valueType list.
```c#
public IReadOnlyList<TypeWithComment> ValueTypes { get; }
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



