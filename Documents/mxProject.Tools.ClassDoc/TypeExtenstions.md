



# TypeExtenstions Class



Extension methods for System.Type .








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
| public | [EnumerateBaseTypes(Type)](#enumeratebasetypestype-method) | IEnumerable&lt;Type&gt; | Go up the inheritance tree and enumerate the base types. |
| public | [FormatToReadableTypeName(Type, bool)](#formattoreadabletypenametype-bool-method) | string | Format it to a human-readable name, like "SampleClass&lt;T&gt;". |
| public | [IsAccesibleFromOutsideAssembly(Type)](#isaccesiblefromoutsideassemblytype-method) | bool | Gets whether it can be accessed from outside the assembly. |
| public | [IsClassExcludeDelegateAndInterface(Type)](#isclassexcludedelegateandinterfacetype-method) | bool | Gets a value indicating whether the type is a class, exclude interfaces and delegates. |
| public | [IsDelegate(Type)](#isdelegatetype-method) | bool | Gets a value indicating whether the current System.Type represents a delegate. |
| public | [IsMatchNamespace(Type, Regex)](#ismatchnamespacetype-regex-method) | bool | Gets whether the type namespace matches the specified namespace. |
| public | [IsMatchNamespace(Type, string)](#ismatchnamespacetype-string-method) | bool | Gets whether the type namespace matches the specified namespace. |
| public | [IsRecommendOutputToDocument(Type)](#isrecommendoutputtodocumenttype-method) | bool | Gets whether output to document is recommended. |
---
### EnumerateBaseTypes(Type) Method

Go up the inheritance tree and enumerate the base types.
```c#
public static IEnumerable<Type> EnumerateBaseTypes
(
	this Type type
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  |  |
#### Return type


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
### FormatToReadableTypeName(Type, bool) Method

Format it to a human-readable name, like "SampleClass&lt;T&gt;".
```c#
public static string FormatToReadableTypeName
(
	this Type type
	, bool isFullName
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  |  |
| isFullName | bool |  | A value whether to get the full type name with namespace. |
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
### GetType Method

Inherited from  System.Object .
```c#
public Type GetType()
```
#### Return type


[Go to methods](#Methods)

---
### IsAccesibleFromOutsideAssembly(Type) Method

Gets whether it can be accessed from outside the assembly.
```c#
public static bool IsAccesibleFromOutsideAssembly
(
	Type type
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  |  |
#### Return type
Returns true if public or nested public. Otherwise, false.

[Go to methods](#Methods)

---
### IsClassExcludeDelegateAndInterface(Type) Method

Gets a value indicating whether the type is a class, exclude interfaces and delegates.
```c#
public static bool IsClassExcludeDelegateAndInterface
(
	this Type type
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  |  |
#### Return type


[Go to methods](#Methods)

---
### IsDelegate(Type) Method

Gets a value indicating whether the current System.Type represents a delegate.
```c#
public static bool IsDelegate
(
	this Type type
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  |  |
#### Return type


[Go to methods](#Methods)

---
### IsMatchNamespace(Type, Regex) Method

Gets whether the type namespace matches the specified namespace.
```c#
public static bool IsMatchNamespace
(
	this Type type
	, Regex regex
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  | The type. |
| regex | Regex |  | The regular expression. |
#### Return type
Return true if match, otherwize false.

[Go to methods](#Methods)

---
### IsMatchNamespace(Type, string) Method

Gets whether the type namespace matches the specified namespace.
```c#
public static bool IsMatchNamespace
(
	this Type type
	, string regexPattern
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | Type |  | The type. |
| regexPattern | string |  | The regular expression pattern. |
#### Return type
Return true if match, otherwize false.

[Go to methods](#Methods)

---
### IsRecommendOutputToDocument(Type) Method

Gets whether output to document is recommended.
```c#
public static bool IsRecommendOutputToDocument
(
	this Type method
)
```

If  IsSpecialName  property returns true, then this method will return false.


If  [IsAccesibleFromOutsideAssembly(Type)](#isaccesiblefromoutsideassemblytype-method)  method returns false, then this method will return false.


If  [MemberExtenstions.IsBrowsable(MemberInfo)](../mxProject.Tools.ClassDoc/MemberExtenstions.md#memberextenstionsisbrowsablememberinfo-method)  method returns false, then this method will return false.

#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | Type |  |  |
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



