



# PropertyInfoExtensions Class



Extension methods for System.Reflection.PropertyInfo .








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
| public | [FormatToDeclaretion(PropertyInfo)](#formattodeclaretionpropertyinfo-method) | string | Foramt it to a declaretion statement. |
| public | [FormatToReadableSignature(PropertyInfo)](#formattoreadablesignaturepropertyinfo-method) | string | Format it to a human-readable name or signature, like "Item[int]". |
| public | [FormatToXmlCommentSignature(PropertyInfo)](#formattoxmlcommentsignaturepropertyinfo-method) | string | Format it to a XML comment signature, like "P:SampleNamespace.SampleClass.Item(System.Int32)". |
| public | [GetGettterScope(PropertyInfo)](#getgettterscopepropertyinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of the get accessor. |
| public | [GetSettterScope(PropertyInfo)](#getsettterscopepropertyinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope of the set accessor. |
| public | [IsAccesibleFromOutsideAssembly(PropertyInfo)](#isaccesiblefromoutsideassemblypropertyinfo-method) | bool | Gets whether it can be accessed from outside the assembly. |
| public | [IsRecommendOutputToDocument(PropertyInfo)](#isrecommendoutputtodocumentpropertyinfo-method) | bool | Gets whether output to document is recommended. |
| public | [IsStatic(PropertyInfo)](#isstaticpropertyinfo-method) | bool | Gets a value indicating whether the property is static. |
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
### FormatToDeclaretion(PropertyInfo) Method

Foramt it to a declaretion statement.
```c#
public static string FormatToDeclaretion
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableSignature(PropertyInfo) Method

Format it to a human-readable name or signature, like "Item[int]".
```c#
public static string FormatToReadableSignature
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToXmlCommentSignature(PropertyInfo) Method

Format it to a XML comment signature, like "P:SampleNamespace.SampleClass.Item(System.Int32)".
```c#
public static string FormatToXmlCommentSignature
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### GetGettterScope(PropertyInfo) Method

Gets the scope of the get accessor.
```c#
public static MemberScope GetGettterScope
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
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
### GetSettterScope(PropertyInfo) Method

Gets the scope of the set accessor.
```c#
public static MemberScope GetSettterScope
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
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
### IsAccesibleFromOutsideAssembly(PropertyInfo) Method

Gets whether it can be accessed from outside the assembly.
```c#
public static bool IsAccesibleFromOutsideAssembly
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
#### Return type
Returns true if getter or setter is accessible. Otherwise, false.

[Go to methods](#Methods)

---
### IsRecommendOutputToDocument(PropertyInfo) Method

Gets whether output to document is recommended.
```c#
public static bool IsRecommendOutputToDocument
(
	this PropertyInfo property
)
```

If  IsSpecialName  property returns true, then this method will return false.


If  [IsAccesibleFromOutsideAssembly(PropertyInfo)](#isaccesiblefromoutsideassemblypropertyinfo-method)  method returns false, then this method will return false.


If  [MemberExtenstions.IsBrowsable(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisbrowsablememberinfo-method)  method returns false, then this method will return false.


If the type for which the spacified method is declared is delegate, then this method will return false.

#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
#### Return type
Returns true if recommended. Otherwise, false.

[Go to methods](#Methods)

---
### IsStatic(PropertyInfo) Method

Gets a value indicating whether the property is static.
```c#
public static bool IsStatic
(
	this PropertyInfo property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | PropertyInfo |  |  |
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



