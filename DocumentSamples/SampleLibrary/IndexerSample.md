



# IndexerSample Class



Indexer sample.








## Inheritance tree
* object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor](#ctor-constructor) |  |
---
### .ctor Constructor


```c#
public IndexerSample()
```

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Item[(int, int)]](#itemint-int-property) | byte | An indexer that takes a tuple as arguments |
| public | [Item[int, int]](#itemint-int-property) | byte | An indexer that takes x and y coordinates as arguments |
| public | [Item[int]](#itemint-property) | byte | An indexer that takes an integer value as an argument. |
| public | [Item[string]](#itemstring-property) | byte | An indexer that takes a string value as an argument. |
---
### Item[(int, int)] Property

An indexer that takes a tuple as arguments
```c#
public byte Item[(int, int) coordinates] { get; set; }
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| coordinates | (int, int) | The coordinates. |

[Go to properties](#Properties)

---
### Item[int, int] Property

An indexer that takes x and y coordinates as arguments
```c#
public byte Item[int x, int y] { get; set; }
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| x | int | The x coordinate. |
| y | int | The y coordinate. |

[Go to properties](#Properties)

---
### Item[int] Property

An indexer that takes an integer value as an argument.
```c#
public byte Item[int index] { get; set; }
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| index | int | The index. |

[Go to properties](#Properties)

---
### Item[string] Property

An indexer that takes a string value as an argument.
```c#
public byte Item[string name] { get; set; }
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| name | string | The name. |

[Go to properties](#Properties)





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
### ToString Method

Inherited from  System.Object .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)



