namespace Unity.Profiling.LowLevel;

[Flags]
public enum MarkerFlags
{
	Default = 0,
	Script = 2,
	ScriptInvoke = 32,
	ScriptDeepProfiler = 64,
	AvailabilityEditor = 4,
	AvailabilityNonDevelopment = 8,
	Warning = 16,
	Counter = 128,
	SampleGPU = 256,
}

