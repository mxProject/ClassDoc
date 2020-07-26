



# CommentSample&lt;TItem&gt; Class



XML comment sample.





First paragraph of remarks.


Second paragraph of remarks.


Link to type :  [SampleClass](../SampleLibrary/SampleClass.md) 


Link to type :  [see SampleClass](../SampleLibrary/SampleClass.md) 


Link to type :  [SampleSubClass](../SampleLibrary/SampleSubClass.md) 


Link to type :  [seealso SampleSubClass](../SampleLibrary/SampleSubClass.md) 


Link to method :  [SampleClass.Action(byte)](../SampleLibrary/SampleClass.md#sampleclassactionbyte-method) 


Link to method :  [see SampleClass.Action](../SampleLibrary/SampleClass.md#sampleclassactionbyte-method) 


Link to method :  [SampleSubClass.SubClassAction(long)](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassactionlong-method) 


Link to method :  [seealso SampleSubClass.SubClassAction](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassactionlong-method) 


Link to property :  [SampleClass.Property](../SampleLibrary/SampleClass.md#sampleclassproperty-property) 


Link to property :  [see SampleClass.Property](../SampleLibrary/SampleClass.md#sampleclassproperty-property) 


Link to property :  [SampleSubClass.SubClassProperty](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassproperty-property) 


Link to property :  [seealso SampleSubClass.SubClassProperty](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassproperty-property) 


Link to field :  [SampleClass.Field](../SampleLibrary/SampleClass.md#sampleclassfield-field) 


Link to field :  [see SampleClass.Field](../SampleLibrary/SampleClass.md#sampleclassfield-field) 


Link to field :  [SampleSubClass.SubClassField](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassfield-field) 


Link to field :  [seealso SampleSubClass.SubClassField](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassfield-field) 


Link to event :  [SampleClass.Event](../SampleLibrary/SampleClass.md#sampleclassevent-event) 


Link to event :  [see SampleClass.Event](../SampleLibrary/SampleClass.md#sampleclassevent-event) 


Link to event :  [SampleSubClass.SubClassEvent](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassevent-event) 


Link to event :  [seealso SampleSubClass.SubClassEvent](../SampleLibrary/SampleSubClass.md#samplesubclasssubclassevent-event) 




## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| TItem | The type of the value. |  |

## Inheritance tree
* System.Object

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
public CommentSample()
```

[Go to constructors](#Constructors)






---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetConvertedValue&lt;TResult&gt;(string, Converter&lt;TItem, TResult&gt;)](#getconvertedvaluetresultstring-convertertitem-tresult-method) | TResult | Gets the value corresponding to the specified name. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| public | [GetValue(string)](#getvaluestring-method) | TItem | Gets the value corresponding to the specified name. |
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
### GetConvertedValue&lt;TResult&gt;(string, Converter&lt;TItem, TResult&gt;) Method

Gets the value corresponding to the specified name.
```c#
public TResult GetConvertedValue<TResult>
(
	string name
	, Converter<TItem, TResult> converter
)
```
## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| TResult | The type of converted value. |  |
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| name | string |  | The name. |
| converter | Converter&lt;TItem, TResult&gt; |  | The value converter. |
#### Return type
A converted value.
#### Exceptions
|Exception Type|Message|
|:--|:--|
| ArgumentNullException |  `name` is null.  `converter` is null. |

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
### GetValue(string) Method

Gets the value corresponding to the specified name.
```c#
public TItem GetValue
(
	string name
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| name | string |  | The name. |
#### Return type
A value corresponding to the specified name.
#### Exceptions
|Exception Type|Message|
|:--|:--|
| ArgumentNullException |  `name` is null. |
| ObjectDisposedException | This instance is already disposed. |

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



