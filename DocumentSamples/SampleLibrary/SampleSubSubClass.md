



# SampleSubSubClass Class



Sub class of [SampleSubClass](../SampleLibrary/SampleSubClass.md) .








## Inheritance tree
* [SampleLibrary.SampleSubClass](../SampleLibrary/SampleSubClass.md)
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
public SampleSubSubClass()
```

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractProperty](#abstractproperty-property) | int | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [Property](#property-property) | byte | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [SubClassProperty](#subclassproperty-property) | long | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [SubSubClassProperty](#subsubclassproperty-property) | long | A property declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) . |
| public | [VirtualProperty](#virtualproperty-property) | short | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
---
### AbstractProperty Property

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public virtual int AbstractProperty { get; set; }
```

[Go to properties](#Properties)

---
### Property Property

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public byte Property { get; set; }
```

[Go to properties](#Properties)

---
### SubClassProperty Property

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public long SubClassProperty { get; set; }
```

[Go to properties](#Properties)

---
### SubSubClassProperty Property

A property declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) .
```c#
public long SubSubClassProperty { get; set; }
```

[Go to properties](#Properties)

---
### VirtualProperty Property

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
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
| public | [SubClassField](#subclassfield-field) | string |  |
| public | [SubSubClassField](#subsubclassfield-field) | string | A field declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) . |
---
### Field Field



[Go to fields](#Fields)

---
### ReadonlyField Field



[Go to fields](#Fields)

---
### SubClassField Field



[Go to fields](#Fields)

---
### SubSubClassField Field

A field declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) .

[Go to fields](#Fields)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractAction(int)](#abstractactionint-method) | void | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [Action(byte)](#actionbyte-method) | void | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [Action(byte)](#actionbyte-method) | void | Inherited from  [SampleClass](../SampleLibrary/SampleClass.md) . |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [SubClassAction(long)](#subclassactionlong-method) | void | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [SubSubClassAction(long)](#subsubclassactionlong-method) | void | An action declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
| public | [VirtualAction(short)](#virtualactionshort-method) | void | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
---
### AbstractAction(int) Method

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public virtual void AbstractAction
(
	int arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | int |  |  |

[Go to methods](#Methods)

---
### Action(byte) Method

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
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

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public void SubClassAction
(
	long arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | long |  |  |

[Go to methods](#Methods)

---
### SubSubClassAction(long) Method

An action declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) .
```c#
public void SubSubClassAction
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

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .
```c#
public virtual void VirtualAction
(
	short arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | short |  |  |

[Go to methods](#Methods)


---
## Events
|Scope|Name|EventHandler Type|Summary|
|:--|:--|:--|:--|
| public | [AbstractEvent](#abstractevent-event) | EventHandler | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [Event](#event-event) | EventHandler | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [SubClassEvent](#subclassevent-event) | EventHandler | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
| public | [SubSubClassEvent](#subsubclassevent-event) | EventHandler | An event declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) . |
| public | [VirtualEvent](#virtualevent-event) | EventHandler | Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) . |
---
### AbstractEvent Event

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to events](#Events)

---
### Event Event

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to events](#Events)

---
### SubClassEvent Event

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to events](#Events)

---
### SubSubClassEvent Event

An event declared in [SampleSubSubClass](../SampleLibrary/SampleSubSubClass.md) .

[Go to events](#Events)

---
### VirtualEvent Event

Inherited from  [SampleSubClass](../SampleLibrary/SampleSubClass.md) .

[Go to events](#Events)


