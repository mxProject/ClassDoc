



# GenericClass&lt;T1, T2&gt;.NestedClass Class



Nested class.







## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| T1 | 1st type parameter. | class, new() |
| T2 | 2nd type parameter. | struct |

## Inheritance tree
* object

[Constructors](#Constructors)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor](#ctor-constructor) |  |
---
### .ctor Constructor


```c#
public NestedClass()
```

[Go to constructors](#Constructors)






---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Action(T1, T2)](#actiont1-t2-method) | void | A method that takes the type parameter. |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GenericAction&lt;M1, M2&gt;(T1, M1, T2, M2)](#genericactionm1-m2t1-m1-t2-m2-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### Action(T1, T2) Method

A method that takes the type parameter.
```c#
public void Action
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
### GenericAction&lt;M1, M2&gt;(T1, M1, T2, M2) Method

A generic method that takes the type parameter and the type parameter of this method.
```c#
public void GenericAction<M1, M2>
(
	T1 t1
	, M1 m1
	, T2 t2
	, M2 m2
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
| M2 | 2st type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| m1 | M1 |  | 2nd argument. |
| t2 | T2 |  | 3rd argument. |
| m2 | M2 |  | 4th argument. |

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



