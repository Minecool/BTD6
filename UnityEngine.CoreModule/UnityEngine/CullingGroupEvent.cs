namespace UnityEngine;

public struct CullingGroupEvent
{
	private int m_Index; //Field offset: 0x0
	private byte m_PrevState; //Field offset: 0x4
	private byte m_ThisState; //Field offset: 0x5

	public int currentDistance
	{
		 get { } //Length: 10
	}

	public int index
	{
		 get { } //Length: 5
	}

	public bool isVisible
	{
		 get { } //Length: 10
	}

	public int previousDistance
	{
		 get { } //Length: 10
	}

	public bool wasVisible
	{
		 get { } //Length: 10
	}

	public int get_currentDistance() { }

	public int get_index() { }

	public bool get_isVisible() { }

	public int get_previousDistance() { }

	public bool get_wasVisible() { }

}

