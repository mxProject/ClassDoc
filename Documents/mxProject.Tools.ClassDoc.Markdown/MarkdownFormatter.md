



# MarkdownFormatter Class



Document formatter for Markdown.








## Inheritance tree
* System.Object
## Implemented interfaces
* [mxProject.Tools.ClassDoc.IClassDocumentFormatter](../mxProject.Tools.ClassDoc/IClassDocumentFormatter.md)

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(ClassDocContext)](#ctorclassdoccontext-constructor) | Creates a new instance. |
---
### .ctor(ClassDocContext) Constructor

Creates a new instance.
```c#
public MarkdownFormatter(
	ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [ConstructorAnchorDefaultFormat](#constructoranchordefaultformat-property) | string | Gets or sets the default format string applied to a constructor anchor. |
| public | [EventAnchorDefaultFormat](#eventanchordefaultformat-property) | string | Gets or sets the default format string applied to an event anchor. |
| public | [FieldAnchorDefaultFormat](#fieldanchordefaultformat-property) | string | Gets or sets the default format string applied to a field anchor. |
| public | [MethodAnchorDefaultFormat](#methodanchordefaultformat-property) | string | Gets or sets the default format string applied to a method anchor. |
| public | [ParameterNameDefaultFormat](#parameternamedefaultformat-property) | string | Gets or sets the default format string applied to the a parameter name. |
| public | [PropertyAnchorDefaultFormat](#propertyanchordefaultformat-property) | string | Gets or sets the default format string applied to a property anchor. |
---
### ConstructorAnchorDefaultFormat Property

Gets or sets the default format string applied to a constructor anchor.
```c#
public string ConstructorAnchorDefaultFormat { get; set; }
```

[Go to properties](#Properties)

---
### EventAnchorDefaultFormat Property

Gets or sets the default format string applied to an event anchor.
```c#
public string EventAnchorDefaultFormat { get; set; }
```

[Go to properties](#Properties)

---
### FieldAnchorDefaultFormat Property

Gets or sets the default format string applied to a field anchor.
```c#
public string FieldAnchorDefaultFormat { get; set; }
```

[Go to properties](#Properties)

---
### MethodAnchorDefaultFormat Property

Gets or sets the default format string applied to a method anchor.
```c#
public string MethodAnchorDefaultFormat { get; set; }
```

[Go to properties](#Properties)

---
### ParameterNameDefaultFormat Property

Gets or sets the default format string applied to the a parameter name.
```c#
public string ParameterNameDefaultFormat { get; set; }
```

[Go to properties](#Properties)

---
### PropertyAnchorDefaultFormat Property

Gets or sets the default format string applied to a property anchor.
```c#
public string PropertyAnchorDefaultFormat { get; set; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [FormatToAnchor(ConstructorInfoWithComment, string)](#formattoanchorconstructorinfowithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToAnchor(EventInfoWithComment, string)](#formattoanchoreventinfowithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToAnchor(FieldInfoWithComment, string)](#formattoanchorfieldinfowithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToAnchor(MethodInfoWithComment, string)](#formattoanchormethodinfowithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToAnchor(PropertyInfoWithComment, string)](#formattoanchorpropertyinfowithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToAnchor(TypeWithComment, string)](#formattoanchortypewithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToLink(TypeWithComment, bool, string, string)](#formattolinktypewithcomment-bool-string-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToLink(TypeWithComment, ConstructorInfoWithComment, string, string)](#formattolinktypewithcomment-constructorinfowithcomment-string-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToLink(TypeWithComment, EventInfoWithComment, string, string)](#formattolinktypewithcomment-eventinfowithcomment-string-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToLink(TypeWithComment, FieldInfoWithComment, string, string)](#formattolinktypewithcomment-fieldinfowithcomment-string-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToLink(TypeWithComment, MethodInfoWithComment, string, string)](#formattolinktypewithcomment-methodinfowithcomment-string-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToLink(TypeWithComment, PropertyInfoWithComment, string, string)](#formattolinktypewithcomment-propertyinfowithcomment-string-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToReadableName(TypeWithComment, bool)](#formattoreadablenametypewithcomment-bool-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToReadableSignature(ConstructorInfoWithComment)](#formattoreadablesignatureconstructorinfowithcomment-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToReadableSignature(MethodInfoWithComment)](#formattoreadablesignaturemethodinfowithcomment-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [FormatToReadableSignature(PropertyInfoWithComment)](#formattoreadablesignaturepropertyinfowithcomment-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ReplaceReferenceTag(TypeWithComment, string)](#replacereferencetagtypewithcomment-string-method) | string | Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
## Static Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [ToAnchor(string)](#toanchorstring-method) | string | Converts the specified string to anchor format. |
| public | [WriteBullets(IEnumerable&lt;string&gt;, string, int)](#writebulletsienumerablestring-string-int-method) | string | Outputs the specified string in a bullet list. |
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
### FormatToAnchor(ConstructorInfoWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToAnchor
(
	ConstructorInfoWithComment constructor
	, string format = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| constructor | [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) |  |  |
| format | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToAnchor(EventInfoWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToAnchor
(
	EventInfoWithComment evt
	, string format = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | [EventInfoWithComment](../mxProject.Tools.ClassDoc/EventInfoWithComment.md) |  |  |
| format | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToAnchor(FieldInfoWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToAnchor
(
	FieldInfoWithComment evt
	, string format = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| evt | [FieldInfoWithComment](../mxProject.Tools.ClassDoc/FieldInfoWithComment.md) |  |  |
| format | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToAnchor(MethodInfoWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToAnchor
(
	MethodInfoWithComment method
	, string format = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | [MethodInfoWithComment](../mxProject.Tools.ClassDoc/MethodInfoWithComment.md) |  |  |
| format | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToAnchor(PropertyInfoWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToAnchor
(
	PropertyInfoWithComment property
	, string format = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | [PropertyInfoWithComment](../mxProject.Tools.ClassDoc/PropertyInfoWithComment.md) |  |  |
| format | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToAnchor(TypeWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToAnchor
(
	TypeWithComment type
	, string format = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| format | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, bool, string, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToLink
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
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| isFullName | bool |  |  |
| displayFormat | string |  |  |
| anchorFormat | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, ConstructorInfoWithComment, string, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToLink
(
	TypeWithComment thisType
	, ConstructorInfoWithComment constructor
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| thisType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| constructor | [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) |  |  |
| displayFormat | string |  |  |
| anchorFormat | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, EventInfoWithComment, string, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToLink
(
	TypeWithComment thisType
	, EventInfoWithComment evt
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| thisType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| evt | [EventInfoWithComment](../mxProject.Tools.ClassDoc/EventInfoWithComment.md) |  |  |
| displayFormat | string |  |  |
| anchorFormat | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, FieldInfoWithComment, string, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToLink
(
	TypeWithComment thisType
	, FieldInfoWithComment evt
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| thisType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| evt | [FieldInfoWithComment](../mxProject.Tools.ClassDoc/FieldInfoWithComment.md) |  |  |
| displayFormat | string |  |  |
| anchorFormat | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, MethodInfoWithComment, string, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToLink
(
	TypeWithComment thisType
	, MethodInfoWithComment method
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| thisType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| method | [MethodInfoWithComment](../mxProject.Tools.ClassDoc/MethodInfoWithComment.md) |  |  |
| displayFormat | string |  |  |
| anchorFormat | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToLink(TypeWithComment, PropertyInfoWithComment, string, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToLink
(
	TypeWithComment thisType
	, PropertyInfoWithComment property
	, string displayFormat = null
	, string anchorFormat = null
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| thisType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| property | [PropertyInfoWithComment](../mxProject.Tools.ClassDoc/PropertyInfoWithComment.md) |  |  |
| displayFormat | string |  |  |
| anchorFormat | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableName(TypeWithComment, bool) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToReadableName
(
	TypeWithComment type
	, bool isFullName
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| type | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| isFullName | bool |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableSignature(ConstructorInfoWithComment) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToReadableSignature
(
	ConstructorInfoWithComment constructor
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| constructor | [ConstructorInfoWithComment](../mxProject.Tools.ClassDoc/ConstructorInfoWithComment.md) |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableSignature(MethodInfoWithComment) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToReadableSignature
(
	MethodInfoWithComment method
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| method | [MethodInfoWithComment](../mxProject.Tools.ClassDoc/MethodInfoWithComment.md) |  |  |
#### Return type


[Go to methods](#Methods)

---
### FormatToReadableSignature(PropertyInfoWithComment) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string FormatToReadableSignature
(
	PropertyInfoWithComment property
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| property | [PropertyInfoWithComment](../mxProject.Tools.ClassDoc/PropertyInfoWithComment.md) |  |  |
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
### MemberwiseClone Method

Inherited from  System.Object .
```c#
protected object MemberwiseClone()
```
#### Return type


[Go to methods](#Methods)

---
### ReplaceReferenceTag(TypeWithComment, string) Method

Inherited from  [MarkdownFormatter](../mxProject.Tools.ClassDoc.Markdown/MarkdownFormatter.md) .
```c#
public virtual string ReplaceReferenceTag
(
	TypeWithComment thisType
	, string text
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| thisType | [TypeWithComment](../mxProject.Tools.ClassDoc/TypeWithComment.md) |  |  |
| text | string |  |  |
#### Return type


[Go to methods](#Methods)

---
### ToAnchor(string) Method

Converts the specified string to anchor format.
```c#
public static string ToAnchor
(
	string text
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| text | string |  | The text. |
#### Return type
The formatted anchor.

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
### WriteBullets(IEnumerable&lt;string&gt;, string, int) Method

Outputs the specified string in a bullet list.
```c#
public static string WriteBullets
(
	IEnumerable<string> lines
	, string mark = "*"
	, int indent = 0
)
```
#### Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| lines | IEnumerable&lt;string&gt; |  |  |
| mark | string |  |  |
| indent | int |  |  |
#### Return type


[Go to methods](#Methods)



