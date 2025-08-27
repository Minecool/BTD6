namespace Assets.Scripts.Simulation.SMath;

public struct Quaternion
{
	public static readonly Quaternion identity; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8
	public float w; //Field offset: 0xC

	public Vector3 EulerAngles
	{
		 get { } //Length: 289
		 set { } //Length: 325
	}

	public float Length
	{
		 get { } //Length: 54
	}

	private static Quaternion() { }

	public Quaternion(float x = 0, float y = 0, float z = 0, float w = 0) { }

	public Quaternion(Quaternion clone) { }

	public Quaternion(Quaternion clone) { }

	public static Quaternion AngleAxis(float degress, Vector3 axis) { }

	public virtual bool Equals(object obj) { }

	public Vector3 get_EulerAngles() { }

	public float get_Length() { }

	public virtual int GetHashCode() { }

	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	public static Quaternion Normalize(Quaternion q) { }

	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	public void Set(float x, float y, float z, float w) { }

	public void set_EulerAngles(Vector3 value) { }

}

