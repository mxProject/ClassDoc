



# SampleGenericFunc&lt;TSample, TResult&gt; Delegate



Sample generic function.



```c#
delegate TResult SampleGenericFunc<TSample, TResult>
(
	TSample sample
)
where TSample : ISample
```




## Generic Parameters
|Name|Description|Constraints|
|:--|:--|:--|
| TSample | The type of the sample instance. | [ISample](../SampleLibrary/ISample.md) |
| TResult | The type of return value. |  |










## Parameters
|Name|Parameter Type|I/O|Description|
|:--|:--|:-:|:--|
| sample | TSample |  | sample instance. |
## Return type
A return value.
