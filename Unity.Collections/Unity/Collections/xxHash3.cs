namespace Unity.Collections;

[BurstCompatible]
[BurstCompatible]
[BurstCompatible]
[BurstCompile]
public static class xxHash3
{
	public static class Hash128Long_00000726$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Hash128Long_00000726$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	}

	internal sealed class Hash128Long_00000726$PostfixBurstDelegate : MulticastDelegate
	{

		public Hash128Long_00000726$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override void Invoke(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	}

	public static class Hash64Long_0000071F$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Hash64Long_0000071F$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static ulong Invoke(Byte* input, Byte* dest, long length, Byte* secret) { }

	}

	internal sealed class Hash64Long_0000071F$PostfixBurstDelegate : MulticastDelegate
	{

		public Hash64Long_0000071F$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override ulong Invoke(Byte* input, Byte* dest, long length, Byte* secret) { }

	}


	private static ulong Avalanche(ulong h64) { }

	internal static void Avx2Accumulate(UInt64* acc, Byte* input, Byte* dest, Byte* secret, long nbStripes, int isHash64) { }

	internal static void Avx2Accumulate512(UInt64* acc, Byte* input, Byte* dest, Byte* secret) { }

	internal static void Avx2HashLongInternalLoop(UInt64* acc, Byte* input, Byte* dest, long length, Byte* secret, int isHash64) { }

	internal static void Avx2ScrambleAcc(UInt64* acc, Byte* secret) { }

	internal static void DefaultAccumulate(UInt64* acc, Byte* input, Byte* dest, Byte* secret, long nbStripes, int isHash64) { }

	internal static void DefaultAccumulate512(UInt64* acc, Byte* input, Byte* dest, Byte* secret, int isHash64) { }

	private static void DefaultHashLongInternalLoop(UInt64* acc, Byte* input, Byte* dest, long length, Byte* secret, int isHash64) { }

	internal static void DefaultScrambleAcc(UInt64* acc, Byte* secret) { }

	[BurstCompile]
	private static void Hash128Long(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	[BurstCompile]
	public static void Hash128Long$BurstManaged(Byte* input, Byte* dest, long length, Byte* secret, out uint4 result) { }

	[BurstCompile]
	private static ulong Hash64Long(Byte* input, Byte* dest, long length, Byte* secret) { }

	[BurstCompile]
	public static ulong Hash64Long$BurstManaged(Byte* input, Byte* dest, long length, Byte* secret) { }

	internal static ulong MergeAcc(UInt64* acc, Byte* secret, ulong start) { }

	private static ulong Mix2Acc(ulong acc0, ulong acc1, Byte* secret) { }

	private static ulong Mul128Fold64(ulong lhs, ulong rhs) { }

	private static ulong Mul32To64(uint x, uint y) { }

	private static ulong Read64LE(Void* addr) { }

	internal static uint4 ToUint4(ulong ul0, ulong ul1) { }

	private static void Write64LE(Void* addr, ulong value) { }

	private static ulong XorShift64(ulong v64, int shift) { }

}

