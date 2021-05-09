



# GenericClass&lt;T1, T2, T3&gt; Class



Generic class with three type parameters declared.







## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| T1 | 1st type parameter. | class, new(), IDisposable |
| T2 | 2nd type parameter. | struct, ICloneable |
| T3 | 3rd type parameter. | [ISample](../SampleLibrary/ISample.md), IEqualityComparer&lt;T3&gt; |

## Inheritance tree
* object

[Constructors](#Constructors)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor](#ctor-constructor) | ctor. |
---
### .ctor Constructor

ctor.
```c#
public GenericClass()
```

[Go to constructors](#Constructors)






---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Action(T1, T2, T3)](#actiont1-t2-t3-method) | void | A method that takes the type parameter, `T1`  and  `T2`  and  `T3` . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [Func(T1, T2)](#funct1-t2-method) | T3 | A method that returns the type parameter, `T3` . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### Action(T1, T2, T3) Method

A method that takes the type parameter, `T1`  and  `T2`  and  `T3` .
```c#
public void Action
(
	T1 t1
	, T2 t2
	, T3 t3
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| t2 | T2 |  | 2nd argument. |
| t3 | T3 |  | 3rd argument. |

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
### Func(T1, T2) Method

A method that returns the type parameter, `T3` .
```c#
public T3 Func
(
	T1 t1
	, T2 t2
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| t2 | T2 |  | 2nd argument. |
#### Return type
Return value.

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



