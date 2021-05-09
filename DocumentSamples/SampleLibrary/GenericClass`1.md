



# GenericClass&lt;T1&gt; Class



Generic class with one type parameter declared.







## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| T1 | 1st type parameter. | class |

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
| public | [Action(T1)](#actiont1-method) | void | A method that takes the type parameter. |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [Func](#func-method) | T1 | A method that returns the type parameter. |
| public | [GenericAction&lt;M1&gt;(M1, T1)](#genericactionm1m1-t1-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GenericAction&lt;M1&gt;(T1, M1)](#genericactionm1t1-m1-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GenericFunc&lt;M1&gt;(M1)](#genericfuncm1m1-method) | T1 | A generic method that takes the type parameter of this method, and returns the type parameter. |
| public | [GenericFunc&lt;M1&gt;(T1)](#genericfuncm1t1-method) | M1 | A generic method that returns the type parameter of this method. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### Action(T1) Method

A method that takes the type parameter.
```c#
public void Action
(
	T1 t1
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | argument. |

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
### Func Method

A method that returns the type parameter.
```c#
public T1 Func()
```
#### Return type
Return value.

[Go to methods](#Methods)

---
### GenericAction&lt;M1&gt;(M1, T1) Method

A generic method that takes the type parameter and the type parameter of this method.
```c#
public void GenericAction<M1>
(
	M1 m1
	, T1 t1
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| m1 | M1 |  | 1st argument. |
| t1 | T1 |  | 2nd argument. |

[Go to methods](#Methods)

---
### GenericAction&lt;M1&gt;(T1, M1) Method

A generic method that takes the type parameter and the type parameter of this method.
```c#
public void GenericAction<M1>
(
	T1 t1
	, M1 m1
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| m1 | M1 |  | 2nd argument. |

[Go to methods](#Methods)

---
### GenericFunc&lt;M1&gt;(M1) Method

A generic method that takes the type parameter of this method, and returns the type parameter.
```c#
public T1 GenericFunc<M1>
(
	M1 m1
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| m1 | M1 |  | argument. |
#### Return type
Return value.

[Go to methods](#Methods)

---
### GenericFunc&lt;M1&gt;(T1) Method

A generic method that returns the type parameter of this method.
```c#
public M1 GenericFunc<M1>
(
	T1 t1
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | argument. |
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



