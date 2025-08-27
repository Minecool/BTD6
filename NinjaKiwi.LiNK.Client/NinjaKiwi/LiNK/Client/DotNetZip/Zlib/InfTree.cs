namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

internal sealed class InfTree
{
	private const int MANY = 1440; //Field offset: 0x0
	internal const int BMAX = 15; //Field offset: 0x0
	internal const int fixed_bd = 5; //Field offset: 0x0
	internal const int fixed_bl = 9; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	internal static readonly Int32[] fixed_tl; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	internal static readonly Int32[] fixed_td; //Field offset: 0x8
	internal static readonly Int32[] cplens; //Field offset: 0x10
	internal static readonly Int32[] cplext; //Field offset: 0x18
	internal static readonly Int32[] cpdist; //Field offset: 0x20
	internal static readonly Int32[] cpdext; //Field offset: 0x28
	internal Int32[] hn; //Field offset: 0x10
	internal Int32[] v; //Field offset: 0x18
	internal Int32[] c; //Field offset: 0x20
	internal Int32[] r; //Field offset: 0x28
	internal Int32[] u; //Field offset: 0x30
	internal Int32[] x; //Field offset: 0x38

	private static InfTree() { }

	public InfTree() { }

	private int huft_build(Int32[] b, int bindex, int n, int s, Int32[] d, Int32[] e, Int32[] t, Int32[] m, Int32[] hp, Int32[] hn, Int32[] v) { }

	internal int inflate_trees_bits(Int32[] c, Int32[] bb, Int32[] tb, Int32[] hp, ZlibCodec z) { }

	internal int inflate_trees_dynamic(int nl, int nd, Int32[] c, Int32[] bl, Int32[] bd, Int32[] tl, Int32[] td, Int32[] hp, ZlibCodec z) { }

	internal static int inflate_trees_fixed(Int32[] bl, Int32[] bd, Int32[][] tl, Int32[][] td, ZlibCodec z) { }

	private void initWorkArea(int vsize) { }

}

