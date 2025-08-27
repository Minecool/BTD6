namespace Unity.Burst;

public sealed class BurstCompilerOptions
{
	internal static readonly bool ForceDisableBurstCompilation; //Field offset: 0x0
	private static readonly bool ForceBurstCompilationSynchronously; //Field offset: 0x1
	internal static readonly bool IsSecondaryUnityProcess; //Field offset: 0x2
	private bool _enableBurstCompilation; //Field offset: 0x10
	private bool _enableBurstSafetyChecks; //Field offset: 0x11
	[CompilerGenerated]
	private readonly bool <IsGlobal>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private Action <OptionsChanged>k__BackingField; //Field offset: 0x18

	public bool EnableBurstCompilation
	{
		 get { } //Length: 5
		 set { } //Length: 229
	}

	public bool EnableBurstSafetyChecks
	{
		 set { } //Length: 33
	}

	private bool IsGlobal
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	internal Action OptionsChanged
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	private static BurstCompilerOptions() { }

	internal BurstCompilerOptions(bool isGlobal) { }

	private static bool CheckIsSecondaryUnityProcess() { }

	public bool get_EnableBurstCompilation() { }

	[CompilerGenerated]
	private bool get_IsGlobal() { }

	[CompilerGenerated]
	internal Action get_OptionsChanged() { }

	private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) { }

	internal static bool HasBurstCompileAttribute(MemberInfo member) { }

	private void MaybeTriggerRecompilation() { }

	private void OnOptionsChanged() { }

	public void set_EnableBurstCompilation(bool value) { }

	public void set_EnableBurstSafetyChecks(bool value) { }

	private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) { }

}

