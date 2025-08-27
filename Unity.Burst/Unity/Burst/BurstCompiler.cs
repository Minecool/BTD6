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
		public static class IsBurstEnabled_00000146$BurstDirectCall
		{
			private static IntPtr Pointer; //Field offset: 0x0

			private static IntPtr GetFunctionPointer() { }

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			public static bool Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class IsBurstEnabled_00000146$PostfixBurstDelegate : MulticastDelegate
		{

			public IsBurstEnabled_00000146$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			public override bool Invoke() { }

		}

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

		[BurstCompile]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		internal static bool IsBurstEnabled$BurstManaged() { }

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

		[CompilerGenerated]
		public MethodInfo get_Method() { }

	}

	internal static bool _IsEnabled; //Field offset: 0x0
	public static readonly BurstCompilerOptions Options; //Field offset: 0x8
	private static readonly MethodInfo DummyMethodInfo; //Field offset: 0x10

	public static bool IsEnabled
	{
		 get { } //Length: 141
	}

	private static BurstCompiler() { }

	private static Void* Compile(object delegateObj, bool isFunctionPointer) { }

	private static Void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing) { }

	public static FunctionPointer<T> CompileFunctionPointer(T delegateMethod) { }

	private static void DummyMethod() { }

	public static bool get_IsEnabled() { }

}

