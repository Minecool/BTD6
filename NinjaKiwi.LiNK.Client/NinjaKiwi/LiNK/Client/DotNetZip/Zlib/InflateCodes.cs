namespace NinjaKiwi.LiNK.Client.DotNetZip.Zlib;

internal sealed class InflateCodes
{
	private const int START = 0; //Field offset: 0x0
	private const int LEN = 1; //Field offset: 0x0
	private const int LENEXT = 2; //Field offset: 0x0
	private const int DIST = 3; //Field offset: 0x0
	private const int DISTEXT = 4; //Field offset: 0x0
	private const int COPY = 5; //Field offset: 0x0
	private const int LIT = 6; //Field offset: 0x0
	private const int WASH = 7; //Field offset: 0x0
	private const int END = 8; //Field offset: 0x0
	private const int BADCODE = 9; //Field offset: 0x0
	internal int mode; //Field offset: 0x10
	internal int len; //Field offset: 0x14
	internal Int32[] tree; //Field offset: 0x18
	internal int tree_index; //Field offset: 0x20
	internal int need; //Field offset: 0x24
	internal int lit; //Field offset: 0x28
	internal int bitsToGet; //Field offset: 0x2C
	internal int dist; //Field offset: 0x30
	internal byte lbits; //Field offset: 0x34
	internal byte dbits; //Field offset: 0x35
	internal Int32[] ltree; //Field offset: 0x38
	internal int ltree_index; //Field offset: 0x40
	internal Int32[] dtree; //Field offset: 0x48
	internal int dtree_index; //Field offset: 0x50

	internal InflateCodes() { }

	internal int InflateFast(int bl, int bd, Int32[] tl, int tl_index, Int32[] td, int td_index, InflateBlocks s, ZlibCodec z) { }

	internal void Init(int bl, int bd, Int32[] tl, int tl_index, Int32[] td, int td_index) { }

	internal int Process(InflateBlocks blocks, int r) { }

}

