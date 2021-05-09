



# PublicClass Class



public class.








## Inheritance tree
* object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Fields](#Fields)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;
[Events](#Events)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| protected | [.ctor(byte)](#ctorbyte-constructor) | protected constructor. |
| public | [.ctor(long)](#ctorlong-constructor) | public constructor. |
| internal<br>protected | [.ctor(short)](#ctorshort-constructor) | protected internal constructor. |
---
### .ctor(byte) Constructor

protected constructor.
```c#
protected PublicClass(
	byte arg
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| arg | byte | argument. |

[Go to constructors](#Constructors)

---
### .ctor(long) Constructor

public constructor.
```c#
public PublicClass(
	long arg
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| arg | long | argument. |

[Go to constructors](#Constructors)

---
### .ctor(short) Constructor

protected internal constructor.
```c#
protected internal PublicClass(
	short arg
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| arg | short | argument. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [InternalGetterProperty](#internalgetterproperty-property) | float | A property whose getter scope is internal. |
| public | [InternalSetterProperty](#internalsetterproperty-property) | float | A property whose setter scope is internal. |
| public | [PrivateGetterProperty](#privategetterproperty-property) | float | A property whose getter scope is private. |
| public | [PrivateSetterProperty](#privatesetterproperty-property) | float | A property whose setter scope is private. |
| public | [ProtectedGetterProperty](#protectedgetterproperty-property) | float | A property whose getter scope is protected. |
| internal<br>protected | [ProtectedInternalProperty](#protectedinternalproperty-property) | short | A protected internal property. |
| protected | [ProtectedProperty](#protectedproperty-property) | byte | A protected property. |
| public | [ProtectedSetterProperty](#protectedsetterproperty-property) | float | A property whose setter scope is protected. |
| public | [PublicProperty](#publicproperty-property) | long | A public property. |
---
### InternalGetterProperty Property

A property whose getter scope is internal.
```c#
public float InternalGetterProperty { internal get; set; }
```

[Go to properties](#Properties)

---
### InternalSetterProperty Property

A property whose setter scope is internal.
```c#
public float InternalSetterProperty { get; internal set; }
```

[Go to properties](#Properties)

---
### PrivateGetterProperty Property

A property whose getter scope is private.
```c#
public float PrivateGetterProperty { private get; set; }
```

[Go to properties](#Properties)

---
### PrivateSetterProperty Property

A property whose setter scope is private.
```c#
public float PrivateSetterProperty { get; private set; }
```

[Go to properties](#Properties)

---
### ProtectedGetterProperty Property

A property whose getter scope is protected.
```c#
public float ProtectedGetterProperty { protected get; set; }
```

[Go to properties](#Properties)

---
### ProtectedInternalProperty Property

A protected internal property.
```c#
protected internal short ProtectedInternalProperty { get; set; }
```

[Go to properties](#Properties)

---
### ProtectedProperty Property

A protected property.
```c#
protected byte ProtectedProperty { get; set; }
```

[Go to properties](#Properties)

---
### ProtectedSetterProperty Property

A property whose setter scope is protected.
```c#
public float ProtectedSetterProperty { get; protected set; }
```

[Go to properties](#Properties)

---
### PublicProperty Property

A public property.
```c#
public long PublicProperty { get; set; }
```

[Go to properties](#Properties)


---
## Fields
|Scope|Name|Field Type|Summary|
|:--|:--|:--|:--|
| protected | [ProtectedField](#protectedfield-field) | byte | A protected field. |
| internal<br>protected | [ProtectedInternalField](#protectedinternalfield-field) | short | A protected internal field. |
| public | [PublicField](#publicfield-field) | long | A public field. |
---
### ProtectedField Field

A protected field.

[Go to fields](#Fields)

---
### ProtectedInternalField Field

A protected internal field.

[Go to fields](#Fields)

---
### PublicField Field

A public field.

[Go to fields](#Fields)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| internal<br>protected | [ProtectedInternalMethod(short)](#protectedinternalmethodshort-method) | void | A protected internal method. |
| protected | [ProtectedMethod(byte)](#protectedmethodbyte-method) | void | A protected method. |
| public | [PublicMethod(long)](#publicmethodlong-method) | void | A public method. |
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
### ProtectedInternalMethod(short) Method

A protected internal method.
```c#
protected internal void ProtectedInternalMethod
(
	short arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | short |  | arguments. |

[Go to methods](#Methods)

---
### ProtectedMethod(byte) Method

A protected method.
```c#
protected void ProtectedMethod
(
	byte arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | byte |  | arguments. |

[Go to methods](#Methods)

---
### PublicMethod(long) Method

A public method.
```c#
public void PublicMethod
(
	long arg
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| arg | long |  | arguments. |

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
## Events
|Scope|Name|EventHandler Type|Summary|
|:--|:--|:--|:--|
| protected | [ProtectedEvent](#protectedevent-event) | EventHandler | A protected event. |
| internal<br>protected | [ProtectedInternalEvent](#protectedinternalevent-event) | EventHandler | A protected internal event. |
| public | [PublicEvent](#publicevent-event) | EventHandler | A public event. |
---
### ProtectedEvent Event

A protected event.

[Go to events](#Events)

---
### ProtectedInternalEvent Event

A protected internal event.

[Go to events](#Events)

---
### PublicEvent Event

A public event.

[Go to events](#Events)


