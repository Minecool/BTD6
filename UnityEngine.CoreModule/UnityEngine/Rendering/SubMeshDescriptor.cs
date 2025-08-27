namespace UnityEngine.Rendering;

public struct SubMeshDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Bounds <bounds>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private MeshTopology <topology>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <indexStart>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <indexCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <baseVertex>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <firstVertex>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <vertexCount>k__BackingField; //Field offset: 0x2C

	public int baseVertex
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Bounds bounds
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int firstVertex
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int indexCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int indexStart
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public MeshTopology topology
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int vertexCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = 0) { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_baseVertex() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Bounds get_bounds() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_firstVertex() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_indexCount() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_indexStart() { }

	[CompilerGenerated]
	[IsReadOnly]
	public MeshTopology get_topology() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_vertexCount() { }

	[CompilerGenerated]
	public void set_baseVertex(int value) { }

	[CompilerGenerated]
	public void set_bounds(Bounds value) { }

	[CompilerGenerated]
	public void set_firstVertex(int value) { }

	[CompilerGenerated]
	public void set_indexCount(int value) { }

	[CompilerGenerated]
	public void set_indexStart(int value) { }

	[CompilerGenerated]
	public void set_topology(MeshTopology value) { }

	[CompilerGenerated]
	public void set_vertexCount(int value) { }

	public virtual string ToString() { }

}

