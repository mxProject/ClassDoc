



# ConstructorInfoExtensions Class



Extension methods for System.Reflection.ConstructorInfo .








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
| public | [FormatToDeclaretion(ConstructorInfo)](#formattodeclaretionconstructorinfo-method) | string | Foramt it to a declaretion statement. |
| public | [FormatToReadableSignature(ConstructorInfo)](#formattoreadablesignatureconstructorinfo-method) | string | Format it to a human-readable signature, like ".ctor(IList&lt;int&gt;)". |
| public | [FormatToXmlCommentSignature(ConstructorInfo)](#formattoxmlcommentsignatureconstructorinfo-method) | string | Format it to a XML comment signature, like "M:SampleNamespace.SampleClass.#ctor(System.Collection.Generic.IList{int})". |
| public | [GetScope(ConstructorInfo)](#getscopeconstructorinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
| public | [IsAccesibleFromOutsideAssembly(ConstructorInfo)](#isaccesiblefromoutsideassemblyconstructorinfo-method) | bool | Gets whether it can be accessed from outside the assembly. |
| public | [IsRecommendOutputToDocument(ConstructorInfo)](#isrecommendoutputtodocumentconstructorinfo-method) | bool | Gets whether output to document is recommended. |
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
### FormatToDeclaretion(ConstructorInfo) Method

Foramt it to a declaretion statement.
```c#
public static string FormatToDeclaretion
(
	this ConstructorInfo ctor
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| ctor | ConstructorInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableSignature(ConstructorInfo) Method

Format it to a human-readable signature, like ".ctor(IList&lt;int&gt;)".
```c#
public static string FormatToReadableSignature
(
	this ConstructorInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | ConstructorInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToXmlCommentSignature(ConstructorInfo) Method

Format it to a XML comment signature, like "M:SampleNamespace.SampleClass.#ctor(System.Collection.Generic.IList{int})".
```c#
public static string FormatToXmlCommentSignature
(
	this ConstructorInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | ConstructorInfo |  |  |
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
### GetScope(ConstructorInfo) Method

Gets the scope.
```c#
public static MemberScope GetScope
(
	this ConstructorInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | ConstructorInfo |  |  |
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
### IsAccesibleFromOutsideAssembly(ConstructorInfo) Method

Gets whether it can be accessed from outside the assembly.
```c#
public static bool IsAccesibleFromOutsideAssembly
(
	this ConstructorInfo ctor
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| ctor | ConstructorInfo |  |  |
#### Return type
Returns true if public or protected. Otherwise, false.

[Go to methods](#Methods)

---
### IsRecommendOutputToDocument(ConstructorInfo) Method

Gets whether output to document is recommended.
```c#
public static bool IsRecommendOutputToDocument
(
	this ConstructorInfo ctor
)
```

If  [IsAccesibleFromOutsideAssembly(ConstructorInfo)](#isaccesiblefromoutsideassemblyconstructorinfo-method)  method returns false, then this method will return false.


If  [MemberExtenstions.IsObsolete(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisobsoletememberinfo-method)  method returns true, then this method will return false.


If  [MemberExtenstions.IsBrowsable(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisbrowsablememberinfo-method)  method returns false, then this method will return false.


If the type for which the specified constructor is declared is delegate, then this method will return false.

#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| ctor | ConstructorInfo |  |  |
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



