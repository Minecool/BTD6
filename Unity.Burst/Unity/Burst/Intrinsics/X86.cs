namespace Unity.Burst.Intrinsics;

[BurstCompile]
public static class X86
{
	internal static class Avx
	{

		[DebuggerStepThrough]
		public static v256 mm256_load_ps(Void* ptr) { }

		[DebuggerStepThrough]
		public static v256 mm256_loadu_si256(Void* ptr) { }

		[DebuggerStepThrough]
		public static v256 mm256_set1_epi32(int a) { }

		[DebuggerStepThrough]
		public static void mm256_store_ps(Void* ptr, v256 val) { }

		[DebuggerStepThrough]
		public static void mm256_storeu_si256(Void* ptr, v256 v) { }

	}

	internal static class Avx2
	{

		public static bool IsAvx2Supported
		{
			 get { } //Length: 3
		}

		public static bool get_IsAvx2Supported() { }

		[DebuggerStepThrough]
		public static v256 mm256_add_epi64(v256 a, v256 b) { }

		[DebuggerStepThrough]
		public static v256 mm256_mul_epu32(v256 a, v256 b) { }

		[DebuggerStepThrough]
		public static v256 mm256_shuffle_epi32(v256 a, int imm8) { }

		[DebuggerStepThrough]
		public static v256 mm256_slli_epi64(v256 a, int imm8) { }

		[DebuggerStepThrough]
		public static v256 mm256_srli_epi64(v256 a, int imm8) { }

		[DebuggerStepThrough]
		public static v256 mm256_xor_si256(v256 a, v256 b) { }

	}

	internal static class Sse
	{

		public static int SHUFFLE(int d, int c, int b, int a) { }

	}

	internal static class Sse2
	{

		[DebuggerStepThrough]
		public static v128 add_epi64(v128 a, v128 b) { }

		[DebuggerStepThrough]
		public static v128 mul_epu32(v128 a, v128 b) { }

		[DebuggerStepThrough]
		public static v128 shuffle_epi32(v128 a, int imm8) { }

		[DebuggerStepThrough]
		public static v128 slli_epi64(v128 a, int imm8) { }

		[DebuggerStepThrough]
		public static v128 srli_epi64(v128 a, int imm8) { }

		[DebuggerStepThrough]
		public static v128 xor_si128(v128 a, v128 b) { }

	}


}

