



# TypeLoader Class



Loads type information.








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
| public | [EnumerateTypes(Assembly, Func&lt;Type, bool&gt;)](#enumeratetypesassembly-functype-bool-method) | IEnumerable&lt;Type&gt; | Enumerates the types defined in the specified assembly. |
| public | [LoadTypes(IEnumerable&lt;string&gt;, ClassDocContext, string)](#loadtypesienumerablestring-classdoccontext-string-method) | IReadOnlyList&lt;TypeWithComment&gt; | Loads the types defined in the specified assemblies. |
| public | [LoadTypes(string, ClassDocContext, string)](#loadtypesstring-classdoccontext-string-method) | IReadOnlyList&lt;TypeWithComment&gt; | Loads the types defined in the specified assembly. |
---
### EnumerateTypes(Assembly, Func&lt;Type, bool&gt;) Method

Enumerates the types defined in the specified assembly.
```c#
public static IEnumerable<Type> EnumerateTypes
(
	Assembly assembly
	, Func<Type, bool> filter
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| assembly | Assembly |  | The assembly. |
| filter | Func&lt;Type, bool&gt; |  | The method to determine if a type should be enumerated. |
#### Return type
The enumerator.

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
### LoadTypes(IEnumerable&lt;string&gt;, ClassDocContext, string) Method

Loads the types defined in the specified assemblies.
```c#
public static IReadOnlyList<TypeWithComment> LoadTypes
(
	IEnumerable<string> dllPaths
	, ClassDocContext context
	, string nameSpace = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| dllPaths | IEnumerable&lt;string&gt; |  | The assembly file path. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) |  | The context that manages the state of the output process for class documents. |
| nameSpace | string |  | The namespace to load. |
#### Return type
The type information.

[Go to methods](#Methods)

---
### LoadTypes(string, ClassDocContext, string) Method

Loads the types defined in the specified assembly.
```c#
public static IReadOnlyList<TypeWithComment> LoadTypes
(
	string dllPath
	, ClassDocContext context
	, string nameSpace = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| dllPath | string |  | The assembly file path. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) |  | The context that manages the state of the output process for class documents. |
| nameSpace | string |  | The namespace to load. |
#### Return type
The type information.

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



