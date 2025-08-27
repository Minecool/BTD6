namespace UnityEngine.U2D;

public class SplineControlPoint
{
	public Vector3 position; //Field offset: 0x10
	public Vector3 leftTangent; //Field offset: 0x1C
	public Vector3 rightTangent; //Field offset: 0x28
	public ShapeTangentMode mode; //Field offset: 0x34
	public float height; //Field offset: 0x38
	public int spriteIndex; //Field offset: 0x3C
	public bool corner; //Field offset: 0x40
	[SerializeField]
	private Corner m_CornerMode; //Field offset: 0x44

	public Corner cornerMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public SplineControlPoint() { }

	public Corner get_cornerMode() { }

	public virtual int GetHashCode() { }

	public void set_cornerMode(Corner value) { }

}

