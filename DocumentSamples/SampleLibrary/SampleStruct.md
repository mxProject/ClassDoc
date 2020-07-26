



# SampleStruct ValueType



Sample structure.








## Inheritance tree
* System.ValueType
* System.Object
## Implemented interfaces
* [SampleLibrary.ISample](../SampleLibrary/ISample.md)

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Fields](#Fields)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(byte)](#ctorbyte-constructor) | ctor. |
---
### .ctor(byte) Constructor

ctor.
```c#
public SampleStruct(
	byte value
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| value | byte |  |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Property](#property-property) | byte | property. |
## Static Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [StaticProperty](#staticproperty-property) | int | static property. |
---
### Property Property

property.
```c#
public byte Property { get; set; }
```

[Go to properties](#Properties)

---
### StaticProperty Property

static property.
```c#
public static int StaticProperty { get; }
```

[Go to properties](#Properties)


---
## Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| public | [Field](#field-field) | byte | field. |
| public | [ReadonlyField](#readonlyfield-field) | short | readonly field. |
## Static Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| public | [StaticField](#staticfield-field) | int | static field. |
| public | [StaticReadonlyField](#staticreadonlyfield-field) | long | static reaonly field. |
---
### Field Field

field.

[Go to fields](#Fields)

---
### ReadonlyField Field

readonly field.

[Go to fields](#Fields)

---
### StaticField Field

static field.

[Go to fields](#Fields)

---
### StaticReadonlyField Field

static reaonly field.

[Go to fields](#Fields)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Action(byte)](#actionbyte-method) | void | action. |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.ValueType . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.ValueType . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.ValueType . |
## Static Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [StaticAction(SampleStruct)](#staticactionsamplestruct-method) | void | static action. |
---
### Action(byte) Method

action.
```c#
public void Action
(
	byte arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | byte |  | argument. |

[Go to methods](#Methods)

---
### Equals(object) Method

Inherited from  System.ValueType .
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

Inherited from  System.ValueType .
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
### StaticAction(SampleStruct) Method

static action.
```c#
public static void StaticAction
(
	SampleStruct sample
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| sample | [SampleStruct](../SampleLibrary/SampleStruct.md) |  | sample instance. |

[Go to methods](#Methods)

---
### ToString Method

Inherited from  System.ValueType .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)



