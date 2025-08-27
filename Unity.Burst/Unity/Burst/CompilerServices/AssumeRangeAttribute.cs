namespace Unity.Burst.CompilerServices;

[AttributeUsage(10240)]
public class AssumeRangeAttribute : Attribute
{

	public AssumeRangeAttribute(long min, long max) { }

}

