namespace UnityEngine;

public struct BlendShapeBufferRange
{
	[SerializeField]
	private uint m_StartIndex; //Field offset: 0x0
	[SerializeField]
	private uint m_EndIndex; //Field offset: 0x4

	internal uint endIndex
	{
		internal set { } //Length: 4
	}

	internal uint startIndex
	{
		internal set { } //Length: 3
	}

	internal void set_endIndex(uint value) { }

	internal void set_startIndex(uint value) { }

}

