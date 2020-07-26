



# FieldInfoExtensions Class



Extension methods for System.Reflection.FieldInfo .








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
| public | [FormatToXmlCommentSignature(FieldInfo)](#formattoxmlcommentsignaturefieldinfo-method) | string | Format it to a XML comment signature, like "F:SampleNamespace.SampleClass.Item". |
| public | [GetScope(FieldInfo)](#getscopefieldinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
| public | [IsAccesibleFromOutsideAssembly(FieldInfo)](#isaccesiblefromoutsideassemblyfieldinfo-method) | bool | Gets whether it can be accessed from outside the assembly. |
| public | [IsRecommendOutputToDocument(FieldInfo)](#isrecommendoutputtodocumentfieldinfo-method) | bool | Gets whether output to document is recommended. |
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
### FormatToXmlCommentSignature(FieldInfo) Method

Format it to a XML comment signature, like "F:SampleNamespace.SampleClass.Item".
```c#
public static string FormatToXmlCommentSignature
(
	this FieldInfo field
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| field | FieldInfo |  |  |
#### Return type


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
### GetScope(FieldInfo) Method

Gets the scope.
```c#
public static MemberScope GetScope
(
	this FieldInfo field
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| field | FieldInfo |  |  |
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
### IsAccesibleFromOutsideAssembly(FieldInfo) Method

Gets whether it can be accessed from outside the assembly.
```c#
public static bool IsAccesibleFromOutsideAssembly
(
	this FieldInfo field
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| field | FieldInfo |  |  |
#### Return type
Returns true if getter or setter is accessible. Otherwise, false.

[Go to methods](#Methods)

---
### IsRecommendOutputToDocument(FieldInfo) Method

Gets whether output to document is recommended.
```c#
public static bool IsRecommendOutputToDocument
(
	this FieldInfo field
)
```

If  IsSpecialName  field returns true, then this method will return false.


If  [IsAccesibleFromOutsideAssembly(FieldInfo)](#isaccesiblefromoutsideassemblyfieldinfo-method)  method returns false, then this method will return false.


If  [MemberExtenstions.IsBrowsable(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisbrowsablememberinfo-method)  method returns false, then this method will return false.

#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| field | FieldInfo |  |  |
#### Return type
Returns true if recommended. Otherwise, false.

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



