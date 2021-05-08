


# RazorDocumentWriter Class



Document writer using Razor.






## Inheritance tree
* System.Object
## Implemented interfaces
* [mxProject.Tools.ClassDoc.IClassDocumentWriter](../mxProject.Tools.ClassDoc/IClassDocumentWriter.md)
* System.IDisposable

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| protected | [.ctor(Encoding, string, string)](#ctorencoding-string-string-constructor) |  |
---
### .ctor(Encoding, string, string) Constructor


```c#
protected RazorDocumentWriter(
	Encoding encoding
	, string namespaceDocumentTemplate
	, string typeDocumentTemplate
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| encoding | Encoding |  |
| namespaceDocumentTemplate | string |  |
| typeDocumentTemplate | string |  |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Encoding](#encoding-property) | Encoding | Gets the encoding. |
| public | [RootDirectory](#rootdirectory-property) | string | Gets or sets the path of the root directory of the output destination. |
---
### Encoding Property

Gets the encoding.
```c#
public Encoding Encoding { get; }
```

[Go to properties](#Properties)

---
### RootDirectory Property

Gets or sets the path of the root directory of the output destination.
```c#
public string RootDirectory { get; set; }
```

[Go to properties](#Properties)




---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Dispose](#dispose-method) | void |  |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
| public | [WriteNamespaceDocument(NamespaceInfo, IClassDocumentFormatter)](#writenamespacedocumentnamespaceinfo-iclassdocumentformatter-method) | void | Inherited from  [RazorDocumentWriter](../mxProject.Tools.ClassDoc.Razors/RazorDocumentWriter.md) . |
| public | [WriteTypeDocument(TypeWithComment, IClassDocumentFormatter)](#writetypedocumenttypewithcomment-iclassdocumentformatter-method) | void | Inherited from  [RazorDocumentWriter](../mxProject.Tools.ClassDoc.Razors/RazorDocumentWriter.md) . |
## Static Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Create(Encoding, string, string)](#createencoding-string-string-method) | [RazorDocumentWriter](../mxProject.Tools.ClassDoc.Razors/RazorDocumentWriter.md) |  |
---
### Create(Encoding, string, string) Method


```c#
public static RazorDocumentWriter Create
(
	Encoding encoding
	, string namespaceDocumentTemplate
	, string typeDocumentTemplate
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| encoding | Encoding |  |  |
| namespaceDocumentTemplate | string |  |  |
| typeDocumentTemplate | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### Dispose Method


```c#
public virtual void Dispose()
```

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

---
### WriteNamespaceDocument(NamespaceInfo, IClassDocumentFormatter) Method

Inherited from  [RazorDocumentWriter](../mxProject.Tools.ClassDoc.Razors/RazorDocumentWriter.md) .
```c#
public virtual void WriteNamespaceDocument
(
	NamespaceInfo nameSpace
	, IClassDocumentFormatter formatter
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| nameSpace | [NamespaceInfo](../mxProject.Tools.ClassDoc/NamespaceInfo.md) |  |  |
| formatter | [IClassDocumentFormatter](../mxProject.Tools.ClassDoc/IClassDocumentFormatter.md) |  |  |

[Go to methods](#Methods)

---
### WriteTypeDocument(TypeWithComment, IClassDocumentFormatter) Method

Inherited from  [RazorDocumentWriter](../mxProject.Tools.ClassDoc.Razors/RazorDocumentWriter.md) .
```c#
public virtual void WriteTypeDocument
(
	TypeWithComment type
	, IClassDocumentFormatter formatter
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| formatter | [IClassDocumentFormatter](../mxProject.Tools.ClassDoc/IClassDocumentFormatter.md) |  |  |

[Go to methods](#Methods)



