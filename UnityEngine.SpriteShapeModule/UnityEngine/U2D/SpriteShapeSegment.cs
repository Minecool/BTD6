namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
public struct SpriteShapeSegment
{
	private int m_GeomIndex; //Field offset: 0x0
	private int m_IndexCount; //Field offset: 0x4
	private int m_VertexCount; //Field offset: 0x8
	private int m_SpriteIndex; //Field offset: 0xC

	public int geomIndex
	{
		 set { } //Length: 3
	}

	public int indexCount
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int spriteIndex
	{
		 set { } //Length: 4
	}

	public int vertexCount
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public int get_indexCount() { }

	public int get_vertexCount() { }

	public void set_geomIndex(int value) { }

	public void set_indexCount(int value) { }

	public void set_spriteIndex(int value) { }

	public void set_vertexCount(int value) { }

}

