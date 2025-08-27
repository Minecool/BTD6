namespace UnityEngine.U2D.Common.UTess;

internal struct ModuleHandle
{
	internal static readonly int kMaxArea; //Field offset: 0x0
	internal static readonly int kMaxEdgeCount; //Field offset: 0x4
	internal static readonly int kMaxIndexCount; //Field offset: 0x8
	internal static readonly int kMaxVertexCount; //Field offset: 0xC
	internal static readonly int kMaxTriangleCount; //Field offset: 0x10
	internal static readonly int kMaxRefineIterations; //Field offset: 0x14
	internal static readonly int kMaxSmoothenIterations; //Field offset: 0x18
	internal static readonly float kIncrementAreaFactor; //Field offset: 0x1C

	private static ModuleHandle() { }

	internal static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	internal static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	internal static int GetEqual(Array<T> values, int count, U check, X condition) { }

	internal static int GetEqual(NativeArray<T> values, int count, U check, X condition) { }

	internal static int GetLower(NativeArray<T> values, int count, U check, X condition) { }

	internal static int GetUpper(NativeArray<T> values, int count, U check, X condition) { }

	internal static void InsertionSort(Void* array, int lo, int hi, U comp) { }

	internal static bool IsInsideCircle(float2 a, float2 b, float2 c, float2 p) { }

	internal static float OrientFast(float2 a, float2 b, float2 c) { }

	internal static double OrientFastDouble(double2 a, double2 b, double2 c) { }

	public static float4 Tessellate(Allocator allocator, in NativeArray<float2>& points, in NativeArray<int2>& edges, ref NativeArray<float2>& outVertices, out int outVertexCount, ref NativeArray<Int32>& outIndices, out int outIndexCount, ref NativeArray<int2>& outEdges, out int outEdgeCount) { }

	private static void TransferOutput(NativeArray<int2> srcEdges, int srcEdgeCount, ref NativeArray<int2>& dstEdges, ref int dstEdgeCount, NativeArray<Int32> srcIndices, int srcIndexCount, ref NativeArray<Int32>& dstIndices, ref int dstIndexCount, NativeArray<float2> srcVertices, int srcVertexCount, ref NativeArray<float2>& dstVertices, ref int dstVertexCount) { }

}

