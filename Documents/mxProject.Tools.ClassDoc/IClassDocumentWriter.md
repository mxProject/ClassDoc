



# IClassDocumentWriter Interface



Provides the functionality required to output a class document.








## Inheritance tree

[Methods](#Methods)&nbsp;&nbsp;






---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [WriteNamespaceDocument(NamespaceInfo, IClassDocumentFormatter)](#writenamespacedocumentnamespaceinfo-iclassdocumentformatter-method) | void | Outputs the information of the specified namespace to the document. |
| public | [WriteTypeDocument(TypeWithComment, IClassDocumentFormatter)](#writetypedocumenttypewithcomment-iclassdocumentformatter-method) | void | Outputs the information of the specified type to the document. |
---
### WriteNamespaceDocument(NamespaceInfo, IClassDocumentFormatter) Method

Outputs the information of the specified namespace to the document.
```c#
void WriteNamespaceDocument
(
	NamespaceInfo nameSpace
	, IClassDocumentFormatter formatter
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| nameSpace | [NamespaceInfo](../mxProject.Tools.ClassDoc/NamespaceInfo.md) |  | The namespace information. |
| formatter | [IClassDocumentFormatter](../mxProject.Tools.ClassDoc/IClassDocumentFormatter.md) |  | The formatter. |

[Go to methods](#Methods)

---
### WriteTypeDocument(TypeWithComment, IClassDocumentFormatter) Method

Outputs the information of the specified type to the document.
```c#
void WriteTypeDocument
(
	TypeWithComment type
	, IClassDocumentFormatter formatter
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information. |
| formatter | [IClassDocumentFormatter](../mxProject.Tools.ClassDoc/IClassDocumentFormatter.md) |  | The formatter. |

[Go to methods](#Methods)



