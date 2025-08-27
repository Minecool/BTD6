namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
[NativeHeader("Runtime/Profiler/Marker.h")]
[UsedByNativeCode]
public sealed class CustomSampler : Sampler
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(CustomSampler customSampler) { }

	}

	internal static CustomSampler s_InvalidCustomSampler; //Field offset: 0x0

	private static CustomSampler() { }

	internal CustomSampler() { }

	private CustomSampler(IntPtr ptr) { }

	public static CustomSampler Create(string name, bool collectGpuData = false) { }

}

