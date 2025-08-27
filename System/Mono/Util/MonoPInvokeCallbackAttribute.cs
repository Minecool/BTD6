namespace Mono.Util;

[AttributeUsage(AttributeTargets::Method (64))]
[Conditional("MONOTOUCH")]
[Conditional("FULL_AOT_RUNTIME")]
[Conditional("UNITY")]
internal sealed class MonoPInvokeCallbackAttribute : Attribute
{

	public MonoPInvokeCallbackAttribute(Type t) { }

}

