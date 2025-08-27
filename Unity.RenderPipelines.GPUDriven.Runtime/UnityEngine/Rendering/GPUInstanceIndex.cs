namespace UnityEngine.Rendering;

internal struct GPUInstanceIndex : IEquatable<GPUInstanceIndex>, IComparable<GPUInstanceIndex>
{
	public static readonly GPUInstanceIndex Invalid; //Field offset: 0x0
	[CompilerGenerated]
	private int <index>k__BackingField; //Field offset: 0x0

	public int index
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 8900
	}

	private static GPUInstanceIndex() { }

	public override int CompareTo(GPUInstanceIndex other) { }

	public override bool Equals(GPUInstanceIndex other) { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_index() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_index(int value) { }

}

