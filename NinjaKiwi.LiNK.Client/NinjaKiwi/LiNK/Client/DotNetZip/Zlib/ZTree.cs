namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

internal sealed class ZTree
{
	private static readonly int HEAP_SIZE; //Field offset: 0x0
	internal const int Buf_size = 16; //Field offset: 0x0
	internal static readonly Int32[] ExtraLengthBits; //Field offset: 0x8
	internal static readonly Int32[] ExtraDistanceBits; //Field offset: 0x10
	internal static readonly Int32[] extra_blbits; //Field offset: 0x18
	internal static readonly SByte[] bl_order; //Field offset: 0x20
	private static readonly SByte[] _dist_code; //Field offset: 0x28
	internal static readonly SByte[] LengthCode; //Field offset: 0x30
	internal static readonly Int32[] LengthBase; //Field offset: 0x38
	internal static readonly Int32[] DistanceBase; //Field offset: 0x40
	internal Int16[] dyn_tree; //Field offset: 0x10
	internal int max_code; //Field offset: 0x18
	internal StaticTree staticTree; //Field offset: 0x20

	private static ZTree() { }

	public ZTree() { }

	internal static int bi_reverse(int code, int len) { }

	internal void build_tree(DeflateManager s) { }

	internal static int DistanceCode(int dist) { }

	internal void gen_bitlen(DeflateManager s) { }

	internal static void gen_codes(Int16[] tree, int max_code, Int16[] bl_count) { }

}

