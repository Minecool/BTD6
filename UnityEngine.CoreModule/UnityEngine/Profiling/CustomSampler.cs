namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Profiler/Marker.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
[UsedByNativeCode]
public sealed class CustomSampler : Sampler
{
	internal static CustomSampler s_InvalidCustomSampler; //Field offset: 0x0

	private static CustomSampler() { }

	internal CustomSampler() { }

	internal CustomSampler(IntPtr ptr) { }

	public static CustomSampler Create(string name, bool collectGpuData = false) { }

}

