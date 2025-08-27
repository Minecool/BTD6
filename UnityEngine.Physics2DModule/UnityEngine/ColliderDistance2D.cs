namespace UnityEngine;

public struct ColliderDistance2D
{
	private Vector2 m_PointA; //Field offset: 0x0
	private Vector2 m_PointB; //Field offset: 0x8
	private Vector2 m_Normal; //Field offset: 0x10
	private float m_Distance; //Field offset: 0x18
	private int m_IsValid; //Field offset: 0x1C

	public float distance
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public bool isValid
	{
		 get { } //Length: 10
		 set { } //Length: 9
	}

	public Vector2 normal
	{
		 get { } //Length: 19
	}

	public Vector2 pointA
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public Vector2 pointB
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float get_distance() { }

	public bool get_isValid() { }

	public Vector2 get_normal() { }

	public Vector2 get_pointA() { }

	public Vector2 get_pointB() { }

	public void set_distance(float value) { }

	public void set_isValid(bool value) { }

	public void set_pointA(Vector2 value) { }

	public void set_pointB(Vector2 value) { }

}

