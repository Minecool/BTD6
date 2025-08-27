namespace UnityEngine;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action beforeReloadSubsystems; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action afterReloadSubsystems; //Field offset: 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; //Field offset: 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; //Field offset: 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action reloadSubsytemsStarted; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action reloadSubsytemsCompleted; //Field offset: 0x30

	private static SubsystemManager() { }

	private static void AddSubsystemSubset(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }

	[RequiredByNativeCode]
	private static void ClearSubsystems() { }

	public static void GetInstances(List<T> subsystems) { }

	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }

	public static void GetSubsystems(List<T> subsystems) { }

	[RequiredByNativeCode]
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	private static void ReloadSubsystemsStarted() { }

	private static void StaticConstructScriptingClassMap() { }

}

