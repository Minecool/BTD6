namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public static class math
{
	public struct IntFloatUnion
	{
		public int intValue; //Field offset: 0x0
		public float floatValue; //Field offset: 0x0

	}

	public struct LongDoubleUnion
	{
		public long longValue; //Field offset: 0x0
		public double doubleValue; //Field offset: 0x0

	}


	public static double abs(double x) { }

	public static float abs(float x) { }

	public static int abs(int x) { }

	public static float acos(float x) { }

	public static bool all(int2 x) { }

	public static bool any(bool2 x) { }

	public static bool any(float2 x) { }

	public static bool any(float4 x) { }

	public static double asdouble(ulong x) { }

	public static double asdouble(long x) { }

	public static float3 asfloat(uint3 x) { }

	public static float asfloat(int x) { }

	public static float asfloat(uint x) { }

	public static int asint(float x) { }

	public static long aslong(double x) { }

	public static uint4 asuint(float4 x) { }

	public static uint3 asuint(float3 x) { }

	public static uint2 asuint(float2 x) { }

	public static uint asuint(float x) { }

	public static uint4 asuint(int4 x) { }

	public static uint3 asuint(int3 x) { }

	public static uint2 asuint(int2 x) { }

	public static ulong asulong(double x) { }

	public static float atan(float x) { }

	public static float2 atan(float2 x) { }

	public static float atan2(float y, float x) { }

	public static int ceillog2(int x) { }

	public static int ceilpow2(int x) { }

	public static int2 ceilpow2(int2 x) { }

	public static long ceilpow2(long x) { }

	public static float clamp(float x, float a, float b) { }

	public static int clamp(int x, int a, int b) { }

	public static float cos(float x) { }

	public static float3 cos(float3 x) { }

	public static float3 cross(float3 x, float3 y) { }

	public static uint csum(uint2 x) { }

	public static uint csum(uint3 x) { }

	public static uint csum(uint4 x) { }

	public static float csum(float3 x) { }

	public static float determinant(float2x2 m) { }

	public static float distance(float3 x, float3 y) { }

	public static float distance(float2 x, float2 y) { }

	public static double distance(double2 x, double2 y) { }

	public static float distancesq(float4 x, float4 y) { }

	public static float distancesq(float3 x, float3 y) { }

	public static float dot(float2 x, float2 y) { }

	public static double dot(double2 x, double2 y) { }

	public static float dot(float3 x, float3 y) { }

	public static float dot(float4 x, float4 y) { }

	public static float f16tof32(uint x) { }

	public static float2 float2(float x, float y) { }

	public static float2x2 float2x2(float2 c0, float2 c1) { }

	public static float3 float3(float x, float2 yz) { }

	public static float3 float3(float x, float y, float z) { }

	public static float3 float3(float2 xy, float z) { }

	public static float3x3 float3x3(quaternion rotation) { }

	public static float4 float4(float3 xyz, float w) { }

	public static float4 float4(float x, float y, float z, float w) { }

	public static float4 float4(float2 xy, float2 zw) { }

	public static float4 float4(float2 xy, float z, float w) { }

	public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	public static float floor(float x) { }

	public static int floorlog2(int x) { }

	internal static uint2 fold_to_uint(double2 x) { }

	internal static uint fold_to_uint(double x) { }

	public static uint hash(uint2 v) { }

	public static uint hash(uint3 v) { }

	public static uint hash(quaternion q) { }

	public static uint hash(bool2 v) { }

	public static uint hash(uint4 v) { }

	public static uint hash(int4 v) { }

	public static uint hash(int3 v) { }

	public static uint hash(float4x4 v) { }

	public static uint hash(float4 v) { }

	public static uint hash(int2 v) { }

	public static uint hash(float3 v) { }

	public static uint hash(float2x2 v) { }

	public static uint hash(float2 v) { }

	public static uint hash(double2 v) { }

	public static uint hash(float3x3 v) { }

	public static int2 int2(int x, int y) { }

	public static bool isinf(double x) { }

	public static double length(double2 x) { }

	public static float length(float2 x) { }

	public static float length(float3 x) { }

	public static float length(float4 x) { }

	public static float lengthsq(float4 x) { }

	public static float lengthsq(float3 x) { }

	public static float lengthsq(float2 x) { }

	public static float3 lerp(float3 x, float3 y, float s) { }

	public static float lerp(float x, float y, float s) { }

	public static float log2(float x) { }

	public static int lzcnt(uint x) { }

	public static int lzcnt(int x) { }

	public static float max(float x, float y) { }

	public static long max(long x, long y) { }

	public static uint max(uint x, uint y) { }

	public static int2 max(int2 x, int2 y) { }

	public static int max(int x, int y) { }

	public static float2 max(float2 x, float2 y) { }

	public static float3 max(float3 x, float3 y) { }

	public static long min(long x, long y) { }

	public static float min(float x, float y) { }

	public static float2 min(float2 x, float2 y) { }

	public static float3 min(float3 x, float3 y) { }

	public static double min(double x, double y) { }

	public static double2 min(double2 x, double2 y) { }

	public static uint min(uint x, uint y) { }

	public static int min(int x, int y) { }

	public static quaternion mul(quaternion a, quaternion b) { }

	public static float4x4 mul(float4x4 a, float4x4 b) { }

	public static float4 mul(float4x4 a, float4 b) { }

	public static float2 normalize(float2 x) { }

	public static float3 normalize(float3 x) { }

	public static float pow(float x, float y) { }

	public static quaternion quaternion(float4 value) { }

	public static float radians(float x) { }

	public static float2 rcp(float2 x) { }

	public static float rcp(float x) { }

	public static float rsqrt(float x) { }

	public static uint select(uint a, uint b, bool c) { }

	public static uint2 select(uint2 a, uint2 b, bool2 c) { }

	public static float sin(float x) { }

	public static float3 sin(float3 x) { }

	public static void sincos(float3 x, out float3 s, out float3 c) { }

	public static double sqrt(double x) { }

	public static float sqrt(float x) { }

	public static float3 transform(float4x4 a, float3 b) { }

	public static int tzcnt(ulong x) { }

	public static int tzcnt(int x) { }

	public static int tzcnt(uint x) { }

	public static uint2 uint2(uint x, uint y) { }

	public static uint3 uint3(uint x, uint y, uint z) { }

	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

}

