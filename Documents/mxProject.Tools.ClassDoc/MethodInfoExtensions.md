



# MethodInfoExtensions Class



Extension methods for System.Reflection.MethodInfo .








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
| public | [FormatToDeclaretion(MethodInfo)](#formattodeclaretionmethodinfo-method) | string | Foramt it to a declaretion statement. |
| public | [FormatToReadableSignature(MethodInfo)](#formattoreadablesignaturemethodinfo-method) | string | Format it to a human-readable signature, like "AddValues&lt;T&gt;(IEnumerable&lt;T&gt;)". |
| public | [FormatToXmlCommentSignature(MethodInfo)](#formattoxmlcommentsignaturemethodinfo-method) | string | Format it to a XML comment signature, like "M:SampleNamespace.SampleClass.AddValues`1(System.Collection.Generic.IEnumerable{`0})". |
| public | [GetScope(MethodInfo)](#getscopemethodinfo-method) | [MemberScope](../mxProject.Tools.ClassDoc/MemberScope.md) | Gets the scope. |
| public | [IsAccesibleFromOutsideAssembly(MethodInfo)](#isaccesiblefromoutsideassemblymethodinfo-method) | bool | Gets whether it can be accessed from outside the assembly. |
| public | [IsRecommendOutputToDocument(MethodInfo)](#isrecommendoutputtodocumentmethodinfo-method) | bool | Gets whether output to document is recommended. |
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
### FormatToDeclaretion(MethodInfo) Method

Foramt it to a declaretion statement.
```c#
public static string FormatToDeclaretion
(
	this MethodInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | MethodInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableSignature(MethodInfo) Method

Format it to a human-readable signature, like "AddValues&lt;T&gt;(IEnumerable&lt;T&gt;)".
```c#
public static string FormatToReadableSignature
(
	this MethodInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | MethodInfo |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToXmlCommentSignature(MethodInfo) Method

Format it to a XML comment signature, like "M:SampleNamespace.SampleClass.AddValues`1(System.Collection.Generic.IEnumerable{`0})".
```c#
public static string FormatToXmlCommentSignature
(
	this MethodInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | MethodInfo |  |  |
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
### GetScope(MethodInfo) Method

Gets the scope.
```c#
public static MemberScope GetScope
(
	this MethodInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | MethodInfo |  |  |
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
### IsAccesibleFromOutsideAssembly(MethodInfo) Method

Gets whether it can be accessed from outside the assembly.
```c#
public static bool IsAccesibleFromOutsideAssembly
(
	this MethodInfo method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | MethodInfo |  |  |
#### Return type
Returns true if public or protected. Otherwise, false.

[Go to methods](#Methods)

---
### IsRecommendOutputToDocument(MethodInfo) Method

Gets whether output to document is recommended.
```c#
public static bool IsRecommendOutputToDocument
(
	this MethodInfo method
)
```

If  IsSpecialName  property returns true, then this method will return false.


If  [IsAccesibleFromOutsideAssembly(MethodInfo)](#isaccesiblefromoutsideassemblymethodinfo-method)  method returns false, then this method will return false.


If  [MemberExtenstions.IsBrowsable(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisbrowsablememberinfo-method)  method returns false, then this method will return false.


If the type for which the spacified method is declared is delegate or enum, then this method will return false.

#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | MethodInfo |  |  |
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



