



# TypeWithComment Class



Type information and its XML comment.








## Inheritance tree
* System.Object

[Constructors](#Constructors)&nbsp;&nbsp;
[Properties](#Properties)&nbsp;&nbsp;
[Methods](#Methods)&nbsp;&nbsp;

---
## Constructors
|Scope|Signature|Summary|
|:--|:--|:--|
| public | [.ctor(Type, ILookup&lt;string, XmlComment&gt;, ClassDocContext)](#ctortype-ilookupstring-xmlcomment-classdoccontext-constructor) | Create a new instance. |
---
### .ctor(Type, ILookup&lt;string, XmlComment&gt;, ClassDocContext) Constructor

Create a new instance.
```c#
public TypeWithComment(
	Type type
	, ILookup<string, XmlComment> commentLookup
	, ClassDocContext context
)
```
#### Parameters
|Name|Parameter Type|Description|
|:--|:--|:--|
| type | Type | The type information. |
| commentLookup | ILookup&lt;string, XmlComment&gt; | The XML comment of the type and the members. |
| context | [ClassDocContext](../mxProject.Tools.ClassDoc/ClassDocContext.md) | The context that manages the state of the output process for class documents. |

[Go to constructors](#Constructors)


---
## Properties
|Scope|Name|Property Type|Summary|
|:--|:--|:--|:--|
| public | [Comment](#comment-property) | [XmlComment](../mxProject.Tools.ClassDoc/XmlComment.md) | Gets the XML comment. |
| public | [Constructors](#constructors-property) | IReadOnlyList&lt;ConstructorInfoWithComment&gt; | Gets the constructors. |
| public | [DelegateParameters](#delegateparameters-property) | IReadOnlyList&lt;ParameterInfoWithComment&gt; | Gets the delegate parameters. |
| public | [Events](#events-property) | IReadOnlyList&lt;EventInfoWithComment&gt; | Gets the events. |
| public | [Fields](#fields-property) | IReadOnlyList&lt;FieldInfoWithComment&gt; | Gets the fields. |
| public | [FullName](#fullname-property) | string | Gets the fully qualified name of the type. |
| public | [GenericParameterTypes](#genericparametertypes-property) | IReadOnlyList&lt;TypeParameterWithComment&gt; | Gets the generic parameters. |
| public | [HasDelegateReturnValue](#hasdelegatereturnvalue-property) | bool | Gets whether the delegate returns a return value. |
| public | [HasImplementedInterfaces](#hasimplementedinterfaces-property) | bool | Gets whether it implements the interface. |
| public | [HasInstanceEvent](#hasinstanceevent-property) | bool | Gets whether the instance field exists. |
| public | [HasInstanceField](#hasinstancefield-property) | bool | Gets whether the instance field exists. |
| public | [HasInstanceMethod](#hasinstancemethod-property) | bool | Gets whether the instance method exists. |
| public | [HasInstanceProperty](#hasinstanceproperty-property) | bool | Gets whether the instance property exists. |
| public | [HasStaticEvent](#hasstaticevent-property) | bool | Gets whether the static field exists. |
| public | [HasStaticField](#hasstaticfield-property) | bool | Gets whether the static field exists. |
| public | [HasStaticMethod](#hasstaticmethod-property) | bool | Gets whether the static method exists. |
| public | [HasStaticProperty](#hasstaticproperty-property) | bool | Gets whether the static property exists. |
| public | [Info](#info-property) | Type | Gets the type information. |
| public | [IsClass](#isclass-property) | bool | Gets a value indicating whether the type is a class, exclude interface and delegate. |
| public | [IsDelegate](#isdelegate-property) | bool | Gets a value indicating whether the type is a delegate. |
| public | [IsEnum](#isenum-property) | bool | Gets a value indicating whether the type is an enumeration. |
| public | [IsGenericTypeDefinition](#isgenerictypedefinition-property) | bool | Gets a value indicating whether this type represents a generic type definition. |
| public | [IsInterface](#isinterface-property) | bool | Gets a value indicating whether the type is an interface. |
| public | [IsObsolete](#isobsolete-property) | bool | Gets whether it is obsolete. |
| public | [IsValueType](#isvaluetype-property) | bool | Gets a value indicating whether the type is a valyeType, exclude enumeration. |
| public | [Methods](#methods-property) | IReadOnlyList&lt;MethodInfoWithComment&gt; | Gets the methods. |
| public | [Name](#name-property) | string | Gets the name. |
| public | [Namespace](#namespace-property) | string | Gets the namespace. |
| public | [Properties](#properties-property) | IReadOnlyList&lt;PropertyInfoWithComment&gt; | Gets the properties. |
---
### Comment Property

Gets the XML comment.
```c#
public XmlComment Comment { get; }
```

[Go to properties](#Properties)

---
### Constructors Property

Gets the constructors.
```c#
public IReadOnlyList<ConstructorInfoWithComment> Constructors { get; }
```

[Go to properties](#Properties)

---
### DelegateParameters Property

Gets the delegate parameters.
```c#
public IReadOnlyList<ParameterInfoWithComment> DelegateParameters { get; }
```

[Go to properties](#Properties)

---
### Events Property

Gets the events.
```c#
public IReadOnlyList<EventInfoWithComment> Events { get; }
```

[Go to properties](#Properties)

---
### Fields Property

Gets the fields.
```c#
public IReadOnlyList<FieldInfoWithComment> Fields { get; }
```

[Go to properties](#Properties)

---
### FullName Property

Gets the fully qualified name of the type.
```c#
public string FullName { get; }
```

[Go to properties](#Properties)

---
### GenericParameterTypes Property

Gets the generic parameters.
```c#
public IReadOnlyList<TypeParameterWithComment> GenericParameterTypes { get; }
```

[Go to properties](#Properties)

---
### HasDelegateReturnValue Property

Gets whether the delegate returns a return value.
```c#
public bool HasDelegateReturnValue { get; }
```

[Go to properties](#Properties)

---
### HasImplementedInterfaces Property

Gets whether it implements the interface.
```c#
public bool HasImplementedInterfaces { get; }
```

[Go to properties](#Properties)

---
### HasInstanceEvent Property

Gets whether the instance field exists.
```c#
public bool HasInstanceEvent { get; }
```

[Go to properties](#Properties)

---
### HasInstanceField Property

Gets whether the instance field exists.
```c#
public bool HasInstanceField { get; }
```

[Go to properties](#Properties)

---
### HasInstanceMethod Property

Gets whether the instance method exists.
```c#
public bool HasInstanceMethod { get; }
```

[Go to properties](#Properties)

---
### HasInstanceProperty Property

Gets whether the instance property exists.
```c#
public bool HasInstanceProperty { get; }
```

[Go to properties](#Properties)

---
### HasStaticEvent Property

Gets whether the static field exists.
```c#
public bool HasStaticEvent { get; }
```

[Go to properties](#Properties)

---
### HasStaticField Property

Gets whether the static field exists.
```c#
public bool HasStaticField { get; }
```

[Go to properties](#Properties)

---
### HasStaticMethod Property

Gets whether the static method exists.
```c#
public bool HasStaticMethod { get; }
```

[Go to properties](#Properties)

---
### HasStaticProperty Property

Gets whether the static property exists.
```c#
public bool HasStaticProperty { get; }
```

[Go to properties](#Properties)

---
### Info Property

Gets the type information.
```c#
public Type Info { get; }
```

[Go to properties](#Properties)

---
### IsClass Property

Gets a value indicating whether the type is a class, exclude interface and delegate.
```c#
public bool IsClass { get; }
```

[Go to properties](#Properties)

---
### IsDelegate Property

Gets a value indicating whether the type is a delegate.
```c#
public bool IsDelegate { get; }
```

[Go to properties](#Properties)

---
### IsEnum Property

Gets a value indicating whether the type is an enumeration.
```c#
public bool IsEnum { get; }
```

[Go to properties](#Properties)

---
### IsGenericTypeDefinition Property

Gets a value indicating whether this type represents a generic type definition.
```c#
public bool IsGenericTypeDefinition { get; }
```

[Go to properties](#Properties)

---
### IsInterface Property

Gets a value indicating whether the type is an interface.
```c#
public bool IsInterface { get; }
```

[Go to properties](#Properties)

---
### IsObsolete Property

Gets whether it is obsolete.
```c#
public bool IsObsolete { get; }
```

[Go to properties](#Properties)

---
### IsValueType Property

Gets a value indicating whether the type is a valyeType, exclude enumeration.
```c#
public bool IsValueType { get; }
```

[Go to properties](#Properties)

---
### Methods Property

Gets the methods.
```c#
public IReadOnlyList<MethodInfoWithComment> Methods { get; }
```

[Go to properties](#Properties)

---
### Name Property

Gets the name.
```c#
public string Name { get; }
```

[Go to properties](#Properties)

---
### Namespace Property

Gets the namespace.
```c#
public string Namespace { get; }
```

[Go to properties](#Properties)

---
### Properties Property

Gets the properties.
```c#
public IReadOnlyList<PropertyInfoWithComment> Properties { get; }
```

[Go to properties](#Properties)





---
## Methods
|Scope|Signature|Return Type|Summary|
|:--|:--|:--|:--|
| public | [EnumerateBaseTypes](#enumeratebasetypes-method) | IEnumerable&lt;TypeWithComment&gt; | Goes up the inheritance tree and enumerates the base types. |
| public | [EnumerateImplementedInterfaces](#enumerateimplementedinterfaces-method) | IEnumerable&lt;TypeWithComment&gt; | Enumerates the implemented interface types. |
| public | [Equals(object)](#equalsobject-method) | bool | Inherited from  System.Object . |
| protected | [Finalize](#finalize-method) | void | Inherited from  System.Object . |
| public | [GetDelegateDeclaretion](#getdelegatedeclaretion-method) | string | Gets the declaretion statement. |
| public | [GetHashCode](#gethashcode-method) | int | Inherited from  System.Object . |
| public | [GetType](#gettype-method) | Type | Inherited from  System.Object . |
| protected | [MemberwiseClone](#memberwiseclone-method) | object | Inherited from  System.Object . |
| public | [ToString](#tostring-method) | string | Inherited from  System.Object . |
---
### EnumerateBaseTypes Method

Goes up the inheritance tree and enumerates the base types.
```c#
public IEnumerable<TypeWithComment> EnumerateBaseTypes()
```
#### Return type


[Go to methods](#Methods)

---
### EnumerateImplementedInterfaces Method

Enumerates the implemented interface types.
```c#
public IEnumerable<TypeWithComment> EnumerateImplementedInterfaces()
```
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
### GetDelegateDeclaretion Method

Gets the declaretion statement.
```c#
public string GetDelegateDeclaretion()
```
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
### ToString Method

Inherited from  System.Object .
```c#
public virtual string ToString()
```
#### Return type


[Go to methods](#Methods)



