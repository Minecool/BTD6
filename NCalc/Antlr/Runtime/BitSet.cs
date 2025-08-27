namespace Antlr.Runtime;

public class BitSet
{
	protected private static readonly int MOD_MASK; //Field offset: 0x0
	protected private UInt64[] bits; //Field offset: 0x10

	private static BitSet() { }

	public BitSet() { }

	public BitSet(UInt64[] bits_) { }

	public BitSet(int nbits) { }

	private static ulong BitMask(int bitNumber) { }

	public override object Clone() { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	public override bool Member(int el) { }

	public override BitSet Or(BitSet a) { }

	public override void OrInPlace(BitSet a) { }

	public override void Remove(int el) { }

	private void SetSize(int nwords) { }

	public virtual string ToString() { }

	public override string ToString(String[] tokenNames) { }

	private static int WordNumber(int bit) { }

}

