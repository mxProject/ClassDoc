



# SampleClassExtensions Class



Extension methods for [SampleClass](../SampleLibrary/SampleClass.md) .








## Inheritance tree
* System.Object

[Methods](#Methods)&nbsp;&nbsp;






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
## Static Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [ExtensionAction(SampleClass, bool, DateTime)](#extensionactionsampleclass-bool-datetime-method) | void | An extension action. |
| public | [ExtensionFunc(SampleClass, bool, DateTime)](#extensionfuncsampleclass-bool-datetime-method) | bool | An extension action. |
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
### ExtensionAction(SampleClass, bool, DateTime) Method

An extension action.
```c#
public static void ExtensionAction
(
	this SampleClass sample
	, bool arg1
	, DateTime arg2
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| sample | [SampleClass](../SampleLibrary/SampleClass.md) |  | The instance. |
| arg1 | bool |  | 1st argument. |
| arg2 | DateTime |  | 2nd argument. |

[Go to methods](#Methods)

---
### ExtensionFunc(SampleClass, bool, DateTime) Method

An extension action.
```c#
public static bool ExtensionFunc
(
	this SampleClass sample
	, bool arg1
	, DateTime arg2
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| sample | [SampleClass](../SampleLibrary/SampleClass.md) |  | The instance. |
| arg1 | bool |  | 1st argument. |
| arg2 | DateTime |  | 2nd argument. |
#### Return type
A return value.

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



