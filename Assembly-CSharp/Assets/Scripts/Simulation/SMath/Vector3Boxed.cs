namespace Assets.Scripts.Simulation.SMath;

public class Vector3Boxed
{
	public static Vector3Boxed zero; //Field offset: 0x0
	public static Vector3Boxed foward; //Field offset: 0x8
	private Vector3 data; //Field offset: 0x10

	public float Magnitude
	{
		 get { } //Length: 42
	}

	public float MagnitudeSquared
	{
		 get { } //Length: 36
	}

	public float Rotation
	{
		 get { } //Length: 106
	}

	public float X
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Y
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Z
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	private static Vector3Boxed() { }

	public Vector3Boxed(float x = 0, float y = 0, float z = 0) { }

	public Vector3Boxed(Vector3Boxed clone) { }

	public Vector3Boxed(Vector3 clone) { }

	public Vector3Boxed(Vector3 clone) { }

	public float AngleBetween(Vector3 other) { }

	public float AngleBetween(Vector3Boxed other) { }

	public float Distance(Vector3Boxed b) { }

	public float Distance(Vector3 b) { }

	public float Distance(Vector2 b) { }

	public float DistanceSquared(Vector3 b) { }

	public float DistanceSquared(Vector3Boxed b) { }

	public float DistanceSquared(Vector2 b) { }

	public float DistanceSquared2(Vector3 b) { }

	public float DistanceSquared2(Vector3Boxed b) { }

	public float DistanceSquared2(Vector2 b) { }

	public float Dot(Vector3Boxed with) { }

	public Vector3 Flip(bool inverseYAxis = true) { }

	public float get_Magnitude() { }

	public float get_MagnitudeSquared() { }

	public float get_Rotation() { }

	public float get_X() { }

	public float get_Y() { }

	public float get_Z() { }

	public void Normalize() { }

	public static Vector3 op_Addition(Vector3Boxed a, Vector3 b) { }

	public static Vector3 op_Addition(Vector3Boxed a, Vector3Boxed b) { }

	public static Vector3 op_Implicit(Vector3Boxed vector) { }

	public static Vector3 op_Multiply(Vector3Boxed a, float value) { }

	public static Vector3 op_Subtraction(Vector3Boxed a, Vector3Boxed b) { }

	public static Vector3 op_Subtraction(Vector3Boxed a, Vector3 b) { }

	public void Rotate(float degrees) { }

	public void RotateByQuaternion(Quaternion quaternion) { }

	public void Set(float x, float y, float z) { }

	public void Set(Vector2 clone) { }

	public void Set(Vector3Boxed clone) { }

	public void Set(Vector3 clone) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void set_Z(float value) { }

	public Vector3 ToDisplaySpace(bool tranformByCamera, float cameraOverride) { }

	public Vector3 ToSimulationSpace(bool tranformByCamera, float cameraOverride) { }

	public Vector3 ToUnity() { }

	public Vector2 ToVector2() { }

	public Vector3 ToVector3() { }

}

