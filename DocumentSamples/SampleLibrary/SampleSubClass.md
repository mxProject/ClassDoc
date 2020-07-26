



# SampleSubClass Class



Sub class of [SampleClass](../SampleLibrary/SampleClass.md) .








## Inheritance tree
* [SampleLibrary.SampleClass](../SampleLibrary/SampleClass.md)
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
| public | [.ctor](#ctor-constructor) | ctor. |
---
### .ctor Constructor

ctor.
```c#
public SampleSubClass()
```

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractProperty](#abstractproperty-property) | int | An override property. |
| public | [Property](#property-property) | byte | A new property. |
| public | [SubClassProperty](#subclassproperty-property) | long | A property declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [VirtualProperty](#virtualproperty-property) | short | ( Although "inheritdoc" is specified, the comment of the inheritance source cannot be obtained. ) |
---
### AbstractProperty Property

An override property.
```c#
public virtual int AbstractProperty { get; set; }
```

[Go to properties](#Properties)

---
### Property Property

A new property.
```c#
public byte Property { get; set; }
```

[Go to properties](#Properties)

---
### SubClassProperty Property

A property declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public long SubClassProperty { get; set; }
```

[Go to properties](#Properties)

---
### VirtualProperty Property

( Although "inheritdoc" is specified, the comment of the inheritance source cannot be obtained. )
```c#
public virtual short VirtualProperty { get; set; }
```

[Go to properties](#Properties)


---
## Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| public | [Field](#field-field) | bool |  |
| public | [ReadonlyField](#readonlyfield-field) | short |  |
| public | [SubClassField](#subclassfield-field) | string | A field declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
---
### Field Field



[Go to fields](#Fields)

---
### ReadonlyField Field



[Go to fields](#Fields)

---
### SubClassField Field

A field declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to fields](#Fields)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractAction(int)](#abstractactionint-method) | void | An override action. |
| public | [Action(byte)](#actionbyte-method) | void | A new action. |
| public | [Action(byte)](#actionbyte-method) | void | Inherited from  [SampleClass](../SampleLibrary/SampleClass.md) . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [SubClassAction(long)](#subclassactionlong-method) | void | An action declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
| public | [VirtualAction(short)](#virtualactionshort-method) | void | A virtual action.Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
---
### AbstractAction(int) Method

An override action.
```c#
public virtual void AbstractAction
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

A new action.
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
### Action(byte) Method

Inherited from  [SampleClass](../SampleLibrary/SampleClass.md) .
```c#
public void Action
(
	byte arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | byte |  |  |

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
### SubClassAction(long) Method

An action declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public void SubClassAction
(
	long arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | long |  | argument. |

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

A virtual action.Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
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
| public | [AbstractEvent](#abstractevent-event) | EventHandler | An override event. |
| public | [Event](#event-event) | EventHandler | A new event. |
| public | [SubClassEvent](#subclassevent-event) | EventHandler | An event declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [VirtualEvent](#virtualevent-event) | EventHandler | A virtual event.Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
---
### AbstractEvent Event

An override event.

[Go to events](#Events)

---
### Event Event

A new event.

[Go to events](#Events)

---
### SubClassEvent Event

An event declared in [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to events](#Events)

---
### VirtualEvent Event

A virtual event.Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to events](#Events)


