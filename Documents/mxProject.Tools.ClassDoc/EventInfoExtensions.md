



# EventInfoExtensions Class



Extension methods for System.Reflection.EventInfo .








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
| public | [FormatToXmlCommentSignature(EventInfo)](#formattoxmlcommentsignatureeventinfo-method) | string | Format it to a XML comment signature, like "E:SampleNamespace.SampleClass.AddedItem". |
| public | [GetAddMethodScope(EventInfo)](#getaddmethodscopeeventinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of AddMethod. |
| public | [GetRaiseMethodScope(EventInfo)](#getraisemethodscopeeventinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of RaizeMethod. |
| public | [GetRemoveMethodScope(EventInfo)](#getremovemethodscopeeventinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of RemoveMethod. |
| public | [IsAccesibleFromOutsideAssembly(EventInfo)](#isaccesiblefromoutsideassemblyeventinfo-method) | bool | Gets whether it can be accessed from outside the assembly. |
| public | [IsRecommendOutputToDocument(EventInfo)](#isrecommendoutputtodocumenteventinfo-method) | bool | Gets whether output to document is recommended. |
| public | [IsStatic(EventInfo)](#isstaticeventinfo-method) | bool | Gets a value indicating whether the event is static. |
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
### FormatToXmlCommentSignature(EventInfo) Method

Format it to a XML comment signature, like "E:SampleNamespace.SampleClass.AddedItem".
```c#
public static string FormatToXmlCommentSignature
(
	this EventInfo evt
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### GetAddMethodScope(EventInfo) Method

Gets the scope of AddMethod.
```c#
public static MemberScope GetAddMethodScope
(
	this EventInfo evt
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
#### Return type
The scope.

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
### GetRaiseMethodScope(EventInfo) Method

Gets the scope of RaizeMethod.
```c#
public static MemberScope GetRaiseMethodScope
(
	this EventInfo evt
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
#### Return type
The scope.

[Go to methods](#Methods)

---
### GetRemoveMethodScope(EventInfo) Method

Gets the scope of RemoveMethod.
```c#
public static MemberScope GetRemoveMethodScope
(
	this EventInfo evt
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
#### Return type
The scope.

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
### IsAccesibleFromOutsideAssembly(EventInfo) Method

Gets whether it can be accessed from outside the assembly.
```c#
public static bool IsAccesibleFromOutsideAssembly
(
	this EventInfo evt
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
#### Return type
Returns true if getter or setter is accessible. Otherwise, false.

[Go to methods](#Methods)

---
### IsRecommendOutputToDocument(EventInfo) Method

Gets whether output to document is recommended.
```c#
public static bool IsRecommendOutputToDocument
(
	this EventInfo evt
)
```

If  IsSpecialName  event returns true, then this method will return false.


If  [IsAccesibleFromOutsideAssembly(EventInfo)](#isaccesiblefromoutsideassemblyeventinfo-method)  method returns false, then this method will return false.


If  [MemberExtenstions.IsBrowsable(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisbrowsablememberinfo-method)  method returns false, then this method will return false.

#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
#### Return type
Returns true if recommended. Otherwise, false.

[Go to methods](#Methods)

---
### IsStatic(EventInfo) Method

Gets a value indicating whether the event is static.
```c#
public static bool IsStatic
(
	this EventInfo evt
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | EventInfo |  |  |
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



