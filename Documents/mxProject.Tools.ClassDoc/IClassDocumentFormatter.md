



# IClassDocumentFormatter Interface



Provides the functionality needed to format a class document.








## Inheritance tree

[Methods](#Methods)&nbsp;&nbsp;






---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [FormatToAnchor(ConstructorInfoWithComment, string)](#formattoanchorconstructorinfowithcomment-string-method) | string | Formats the specified constructor into an anchor text. |
| public | [FormatToAnchor(EventInfoWithComment, string)](#formattoanchoreventinfowithcomment-string-method) | string | Formats the specified event into an anchor text. |
| public | [FormatToAnchor(FieldInfoWithComment, string)](#formattoanchorfieldinfowithcomment-string-method) | string | Formats the specified field into an anchor text. |
| public | [FormatToAnchor(MethodInfoWithComment, string)](#formattoanchormethodinfowithcomment-string-method) | string | Formats the specified method into an anchor text. |
| public | [FormatToAnchor(PropertyInfoWithComment, string)](#formattoanchorpropertyinfowithcomment-string-method) | string | Formats the specified property into an anchor text. |
| public | [FormatToAnchor(TypeWithComment, string)](#formattoanchortypewithcomment-string-method) | string | Formats the specified type into an anchor text. |
| public | [FormatToLink(TypeWithComment, bool, string, string)](#formattolinktypewithcomment-bool-string-string-method) | string | Formats the specified type into a link text. |
| public | [FormatToLink(TypeWithComment, ConstructorInfoWithComment, string, string)](#formattolinktypewithcomment-constructorinfowithcomment-string-string-method) | string | Formats the specified constructor into a link text. |
| public | [FormatToLink(TypeWithComment, EventInfoWithComment, string, string)](#formattolinktypewithcomment-eventinfowithcomment-string-string-method) | string | Formats the specified event into a link text. |
| public | [FormatToLink(TypeWithComment, FieldInfoWithComment, string, string)](#formattolinktypewithcomment-fieldinfowithcomment-string-string-method) | string | Formats the specified field into a link text. |
| public | [FormatToLink(TypeWithComment, MethodInfoWithComment, string, string)](#formattolinktypewithcomment-methodinfowithcomment-string-string-method) | string | Formats the specified method into a link text. |
| public | [FormatToLink(TypeWithComment, PropertyInfoWithComment, string, string)](#formattolinktypewithcomment-propertyinfowithcomment-string-string-method) | string | Formats the specified property into a link text. |
| public | [FormatToReadableName(TypeWithComment, bool)](#formattoreadablenametypewithcomment-bool-method) | string | Formats the specified type into a human-readable type name. |
| public | [FormatToReadableSignature(ConstructorInfoWithComment)](#formattoreadablesignatureconstructorinfowithcomment-method) | string | Formats the specified constructor into a human-readable signature. |
| public | [FormatToReadableSignature(MethodInfoWithComment)](#formattoreadablesignaturemethodinfowithcomment-method) | string | Formats the specified method into a human-readable signature. |
| public | [FormatToReadableSignature(PropertyInfoWithComment)](#formattoreadablesignaturepropertyinfowithcomment-method) | string | Formats the specified property into a human-readable signature. |
| public | [ReplaceReferenceTag(TypeWithComment, string)](#replacereferencetagtypewithcomment-string-method) | string | Replaces the reference tag contained in the specified text with the link. |
---
### FormatToAnchor(ConstructorInfoWithComment, string) Method

Formats the specified constructor into an anchor text.
```c#
string FormatToAnchor
(
	ConstructorInfoWithComment constructor
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| constructor | [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) |  | The constructor information. |
| anchorFormat | string |  | The format string. |
#### Return type
The formatted anchor text.

[Go to methods](#Methods)

---
### FormatToAnchor(EventInfoWithComment, string) Method

Formats the specified event into an anchor text.
```c#
string FormatToAnchor
(
	EventInfoWithComment evt
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | [EventInfoWithComment](../mxProject.Tools.ClassDoc/EventInfoWithComment.md) |  | The event information. |
| anchorFormat | string |  | The format string. |
#### Return type
The formatted anchor text.

[Go to methods](#Methods)

---
### FormatToAnchor(FieldInfoWithComment, string) Method

Formats the specified field into an anchor text.
```c#
string FormatToAnchor
(
	FieldInfoWithComment field
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| field | [FieldInfoWithComment](../mxProject.Tools.ClassDoc/FieldInfoWithComment.md) |  | The field information. |
| anchorFormat | string |  | The format string. |
#### Return type
The formatted anchor text.

[Go to methods](#Methods)

---
### FormatToAnchor(MethodInfoWithComment, string) Method

Formats the specified method into an anchor text.
```c#
string FormatToAnchor
(
	MethodInfoWithComment method
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | [MethodInfoWithComment](../mxProject.Tools.ClassDoc/MethodInfoWithComment.md) |  | The method information. |
| anchorFormat | string |  | The format string. |
#### Return type
The formatted anchor text.

[Go to methods](#Methods)

---
### FormatToAnchor(PropertyInfoWithComment, string) Method

Formats the specified property into an anchor text.
```c#
string FormatToAnchor
(
	PropertyInfoWithComment property
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | [PropertyInfoWithComment](../mxProject.Tools.ClassDoc/PropertyInfoWithComment.md) |  | The property information. |
| anchorFormat | string |  | The format string. |
#### Return type
The formatted anchor text.

[Go to methods](#Methods)

---
### FormatToAnchor(TypeWithComment, string) Method

Formats the specified type into an anchor text.
```c#
string FormatToAnchor
(
	TypeWithComment type
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information. |
| anchorFormat | string |  | The format string. |
#### Return type
The formatted anchor text.

[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, bool, string, string) Method

Formats the specified type into a link text.
```c#
string FormatToLink
(
	TypeWithComment type
	, bool isFullName
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information. |
| isFullName | bool |  | A value whether to get the full type name with namespace. |
| displayFormat | string |  | The display format string. |
| anchorFormat | string |  | The anchor format string. |
#### Return type
The formatted link text.

[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, ConstructorInfoWithComment, string, string) Method

Formats the specified constructor into a link text.
```c#
string FormatToLink
(
	TypeWithComment currentType
	, ConstructorInfoWithComment constructor
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| currentType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information that currently being processed. |
| constructor | [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) |  | The constructor information. |
| displayFormat | string |  | The display format string. |
| anchorFormat | string |  | The anchor format string. |
#### Return type
リンク

[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, EventInfoWithComment, string, string) Method

Formats the specified event into a link text.
```c#
string FormatToLink
(
	TypeWithComment currentType
	, EventInfoWithComment evt
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| currentType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information that currently being processed. |
| evt | [EventInfoWithComment](../mxProject.Tools.ClassDoc/EventInfoWithComment.md) |  | The event information. |
| displayFormat | string |  | The display format string. |
| anchorFormat | string |  | The anchor format string. |
#### Return type
The formatted link.

[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, FieldInfoWithComment, string, string) Method

Formats the specified field into a link text.
```c#
string FormatToLink
(
	TypeWithComment currentType
	, FieldInfoWithComment field
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| currentType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information that currently being processed. |
| field | [FieldInfoWithComment](../mxProject.Tools.ClassDoc/FieldInfoWithComment.md) |  | The field information. |
| displayFormat | string |  | The display format string. |
| anchorFormat | string |  | The anchor format string. |
#### Return type
The formatted link.

[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, MethodInfoWithComment, string, string) Method

Formats the specified method into a link text.
```c#
string FormatToLink
(
	TypeWithComment currentType
	, MethodInfoWithComment method
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| currentType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information that currently being processed. |
| method | [MethodInfoWithComment](../mxProject.Tools.ClassDoc/MethodInfoWithComment.md) |  | The method information. |
| displayFormat | string |  | The display format string. |
| anchorFormat | string |  | The anchor format string. |
#### Return type
The formatted link.

[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, PropertyInfoWithComment, string, string) Method

Formats the specified property into a link text.
```c#
string FormatToLink
(
	TypeWithComment currentType
	, PropertyInfoWithComment property
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| currentType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information that currently being processed. |
| property | [PropertyInfoWithComment](../mxProject.Tools.ClassDoc/PropertyInfoWithComment.md) |  | The property information. |
| displayFormat | string |  | The display format string. |
| anchorFormat | string |  | The anchor format string. |
#### Return type
The formatted link.

[Go to methods](#Methods)

---
### FormatToReadableName(TypeWithComment, bool) Method

Formats the specified type into a human-readable type name.
```c#
string FormatToReadableName
(
	TypeWithComment type
	, bool isFullName
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information. |
| isFullName | bool |  | A value whether to get the full type name with namespace. |
#### Return type
The formatted name.

[Go to methods](#Methods)

---
### FormatToReadableSignature(ConstructorInfoWithComment) Method

Formats the specified constructor into a human-readable signature.
```c#
string FormatToReadableSignature
(
	ConstructorInfoWithComment constructor
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| constructor | [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) |  | The constructor information. |
#### Return type
The formatted signature.

[Go to methods](#Methods)

---
### FormatToReadableSignature(MethodInfoWithComment) Method

Formats the specified method into a human-readable signature.
```c#
string FormatToReadableSignature
(
	MethodInfoWithComment method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | [MethodInfoWithComment](../mxProject.Tools.ClassDoc/MethodInfoWithComment.md) |  | The method information. |
#### Return type
The formatted signature.

[Go to methods](#Methods)

---
### FormatToReadableSignature(PropertyInfoWithComment) Method

Formats the specified property into a human-readable signature.
```c#
string FormatToReadableSignature
(
	PropertyInfoWithComment property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | [PropertyInfoWithComment](../mxProject.Tools.ClassDoc/PropertyInfoWithComment.md) |  | The property information. |
#### Return type
The formatted signature.

[Go to methods](#Methods)

---
### ReplaceReferenceTag(TypeWithComment, string) Method

Replaces the reference tag contained in the specified text with the link.
```c#
string ReplaceReferenceTag
(
	TypeWithComment currentType
	, string text
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| currentType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  | The type information that currently being processed. |
| text | string |  | The text. |
#### Return type
The replaced text.

[Go to methods](#Methods)



