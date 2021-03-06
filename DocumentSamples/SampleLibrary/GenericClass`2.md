﻿



# GenericClass&lt;T1, T2&gt; Class



Generic class with two type parameters declared.







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
| public | [Action(T1)](#actiont1-method) | void | A method that takes the type parameter, `T1` . |
| public | [Action(T1, T2)](#actiont1-t2-method) | void | A method that takes the type parameter, `T1`  and  `T2` . |
| public | [Action(T2)](#actiont2-method) | void | A method that takes the type parameter, `T2` . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [Func(T1)](#funct1-method) | T2 | A method that returns the type parameter, `T1` . |
| public | [Func(T2)](#funct2-method) | T1 | A method that returns the type parameter, `T2` . |
| public | [GenericAction&lt;M1, M2&gt;(T1, M1, T2, M2)](#genericactionm1-m2t1-m1-t2-m2-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GenericAction&lt;M1, M2&gt;(T1, T2, M1, M2)](#genericactionm1-m2t1-t2-m1-m2-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GenericAction&lt;M1&gt;(T1, M1, T2)](#genericactionm1t1-m1-t2-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GenericAction&lt;M1&gt;(T1, T2, M1)](#genericactionm1t1-t2-m1-method) | void | A generic method that takes the type parameter and the type parameter of this method. |
| public | [GenericFunc&lt;M1, M2&gt;(T1, T2, M1)](#genericfuncm1-m2t1-t2-m1-method) | M2 | A generic method that returns the type parameter of this method. |
| public | [GenericFunc&lt;M1&gt;(M1, T2)](#genericfuncm1m1-t2-method) | T1 | A generic method that takes the type parameter of this method, and returns the type parameter. |
| public | [GenericFunc&lt;M1&gt;(T1, T2)](#genericfuncm1t1-t2-method) | M1 | A generic method that returns the type parameter of this method. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### Action(T1) Method

A method that takes the type parameter, `T1` .
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
### Action(T1, T2) Method

A method that takes the type parameter, `T1`  and  `T2` .
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
### Action(T2) Method

A method that takes the type parameter, `T2` .
```c#
public void Action
(
	T2 t2
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t2 | T2 |  | argument. |

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
### Func(T1) Method

A method that returns the type parameter, `T1` .
```c#
public T2 Func
(
	T1 t1
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | argument. |
#### Return type
Return value.

[Go to methods](#Methods)

---
### Func(T2) Method

A method that returns the type parameter, `T2` .
```c#
public T1 Func
(
	T2 t2
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t2 | T2 |  | argument. |
#### Return type
Return value.

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
| M2 | 2nd type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| m1 | M1 |  | 2nd argument. |
| t2 | T2 |  | 3rd argument. |
| m2 | M2 |  | 4th argument. |

[Go to methods](#Methods)

---
### GenericAction&lt;M1, M2&gt;(T1, T2, M1, M2) Method

A generic method that takes the type parameter and the type parameter of this method.
```c#
public void GenericAction<M1, M2>
(
	T1 t1
	, T2 t2
	, M1 m1
	, M2 m2
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
| M2 | 2nd type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| t2 | T2 |  | 2nd argument. |
| m1 | M1 |  | 3rd argument. |
| m2 | M2 |  | 4th argument. |

[Go to methods](#Methods)

---
### GenericAction&lt;M1&gt;(T1, M1, T2) Method

A generic method that takes the type parameter and the type parameter of this method.
```c#
public void GenericAction<M1>
(
	T1 t1
	, M1 m1
	, T2 t2
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
| t2 | T2 |  | 3rd argument. |

[Go to methods](#Methods)

---
### GenericAction&lt;M1&gt;(T1, T2, M1) Method

A generic method that takes the type parameter and the type parameter of this method.
```c#
public void GenericAction<M1>
(
	T1 t1
	, T2 t2
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
| t2 | T2 |  | 2nd argument. |
| m1 | M1 |  | 3rd argument. |

[Go to methods](#Methods)

---
### GenericFunc&lt;M1, M2&gt;(T1, T2, M1) Method

A generic method that returns the type parameter of this method.
```c#
public M2 GenericFunc<M1, M2>
(
	T1 t1
	, T2 t2
	, M1 m1
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| M1 | 1st type parameter of this method. |  |
| M2 | 2nd type parameter of this method. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| t1 | T1 |  | 1st argument. |
| t2 | T2 |  | 2nd argument. |
| m1 | M1 |  | 3rd argument. |
#### Return type
Return value.

[Go to methods](#Methods)

---
### GenericFunc&lt;M1&gt;(M1, T2) Method

A generic method that takes the type parameter of this method, and returns the type parameter.
```c#
public T1 GenericFunc<M1>
(
	M1 m1
	, T2 t2
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
| t2 | T2 |  | 2nd argument. |
#### Return type
Return value.

[Go to methods](#Methods)

---
### GenericFunc&lt;M1&gt;(T1, T2) Method

A generic method that returns the type parameter of this method.
```c#
public M1 GenericFunc<M1>
(
	T1 t1
	, T2 t2
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



