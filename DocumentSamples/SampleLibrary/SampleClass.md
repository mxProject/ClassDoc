



# SampleClass Class



Sample class.








## Inheritance tree
* System.Object
## Implemented interfaces
* [SampleLibrary.ISample](../SampleLibrary/ISample.md)

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Fields](#Fields)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;
[Events](#Events)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| protected | [.ctor](#ctor-constructor) | ctor. |
---
### .ctor Constructor

ctor.
```c#
protected SampleClass()
```

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractProperty](#abstractproperty-property) | int | An abstract property. |
| public | [Property](#property-property) | byte | A sealed property. |
| public | [VirtualProperty](#virtualproperty-property) | short | A virtual property. |
## Static Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [StaticProperty](#staticproperty-property) | int | A static property. |
---
### AbstractProperty Property

An abstract property.
```c#
public abstract int AbstractProperty { get; set; }
```

[Go to properties](#Properties)

---
### Property Property

A sealed property.
```c#
public byte Property { get; set; }
```

[Go to properties](#Properties)

---
### StaticProperty Property

A static property.
```c#
public static int StaticProperty { get; }
```

[Go to properties](#Properties)

---
### VirtualProperty Property

A virtual property.
```c#
public virtual short VirtualProperty { get; set; }
```

[Go to properties](#Properties)


---
## Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| public | [Field](#field-field) | bool | A field. |
| public | [ReadonlyField](#readonlyfield-field) | short | A readonly field. |
## Static Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| public | [StaticField](#staticfield-field) | int | A static field. |
| public | [StaticReadonlyField](#staticreadonlyfield-field) | long | A static reaonly field. |
---
### Field Field

A field.

[Go to fields](#Fields)

---
### ReadonlyField Field

A readonly field.

[Go to fields](#Fields)

---
### StaticField Field

A static field.

[Go to fields](#Fields)

---
### StaticReadonlyField Field

A static reaonly field.

[Go to fields](#Fields)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractAction(int)](#abstractactionint-method) | void | An abstract action. |
| public | [Action(byte)](#actionbyte-method) | void | A sealed action. |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
| public | [VirtualAction(short)](#virtualactionshort-method) | void | A virtual action. |
## Static Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [StaticAction(SampleClass)](#staticactionsampleclass-method) | void | A static action. |
---
### AbstractAction(int) Method

An abstract action.
```c#
public abstract void AbstractAction
(
	int arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | int |  | argument. |

[Go to methods](#Methods)

---
### Action(byte) Method

A sealed action.
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
### StaticAction(SampleClass) Method

A static action.
```c#
public static void StaticAction
(
	SampleClass sample
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| sample | [SampleClass](../SampleLibrary/SampleClass.md) |  | sample instance. |

[Go to methods](#Methods)

---
### ToString Method

Inherited from  System.Object .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)

---
### VirtualAction(short) Method

A virtual action.
```c#
public virtual void VirtualAction
(
	short arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | short |  | argument. |

[Go to methods](#Methods)


---
## Events
|Scope|Name|EventHandler Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractEvent](#abstractevent-event) | EventHandler | An abstract event. |
| public | [Event](#event-event) | EventHandler | A sealed event. |
| public | [VirtualEvent](#virtualevent-event) | EventHandler | A virtual event. |
## Static Events
|Scope|Name|EventHandler Type|Summary|
|:--|:--|:--|:--|
| public | [StaticEvent](#staticevent-event) | EventHandler | A static event. |
---
### AbstractEvent Event

An abstract event.

[Go to events](#Events)

---
### Event Event

A sealed event.

[Go to events](#Events)

---
### StaticEvent Event

A static event.

[Go to events](#Events)

---
### VirtualEvent Event

A virtual event.

[Go to events](#Events)


