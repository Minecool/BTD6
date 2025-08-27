namespace Unity.Burst;

public static class BurstCompiler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Attribute, Boolean> <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Compile>b__22_0(Attribute s) { }

	}

	[BurstCompile]
	public static class BurstCompilerHelper
	{
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		private sealed class IsBurstEnabledDelegate : MulticastDelegate
		{

			public IsBurstEnabledDelegate(object object, IntPtr method) { }

			public override bool Invoke() { }

		}

		private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; //Field offset: 0x0
		public static readonly bool IsBurstGenerated; //Field offset: 0x8

		private static BurstCompilerHelper() { }

		[BurstDiscard]
		private static void DiscardedMethod(ref bool value) { }

		[BurstCompile]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		private static bool IsBurstEnabled() { }

		private static bool IsCompiledByBurst(Delegate del) { }

	}

	private class FakeDelegate
	{
		[CompilerGenerated]
		private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

		[Preserve]
		public MethodInfo Method
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public FakeDelegate(MethodInfo method) { }

		[CompilerGenerated]
		public MethodInfo get_Method() { }

	}

	[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
	public class StaticTypeReinitAttribute : Attribute
	{
		public readonly Type reinitType; //Field offset: 0x10

		public StaticTypeReinitAttribute(Type toReinit) { }

	}

	internal static bool _IsEnabled; //Field offset: 0x0
	public static readonly BurstCompilerOptions Options; //Field offset: 0x8
	internal static Action OnCompileILPPMethod2; //Field offset: 0x10
	private static readonly MethodInfo DummyMethodInfo; //Field offset: 0x18

	public static bool IsEnabled
	{
		 get { } //Length: 141
	}

	private static BurstCompiler() { }

	private static Void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing) { }

	public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle) { }

	private static void DummyMethod() { }

	public static bool get_IsEnabled() { }

	public static Void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

}

