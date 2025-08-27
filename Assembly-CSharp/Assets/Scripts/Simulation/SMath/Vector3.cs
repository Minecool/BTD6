namespace Assets.Scripts.Simulation.SMath;

public struct Vector3 : IEquatable<Vector3>
{
	public static readonly Vector3 up; //Field offset: 0x0
	public static readonly Vector3 forward; //Field offset: 0xC
	public static readonly Vector3 back; //Field offset: 0x18
	public static readonly Vector3 left; //Field offset: 0x24
	public static readonly Vector3 right; //Field offset: 0x30
	public static readonly Vector3 zero; //Field offset: 0x3C
	public static readonly Vector3 one; //Field offset: 0x48
	public static readonly Vector3 invalid; //Field offset: 0x54
	public static float cameraAdjustmentCache; //Field offset: 0x60
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8

	[JsonIgnore]
	public float Magnitude
	{
		 get { } //Length: 104
	}

	[JsonIgnore]
	public float MagnitudeSquared
	{
		 get { } //Length: 35
	}

	[JsonIgnore]
	public float Rotation
	{
		 get { } //Length: 50
	}

	[JsonIgnore]
	public float SimToDispRotation
	{
		 get { } //Length: 57
	}

	private static Vector3() { }

	public Vector3(float x = 0, float y = 0, float z = 0) { }

	public Vector3(Vector3 clone) { }

	public Vector3(Vector3 clone) { }

	public Vector3 AddDisplaySpaceHeight(float height, bool transformByCamera, float cameraOverride) { }

	public void AdjustHeightInCameraSpace(float heightIncr) { }

	public float AngleBetween(Vector3 other) { }

	public Vector3 Cross(Vector3 other) { }

	public static Vector3 Cross(Vector3 a, Vector3 b) { }

	public float Distance(Vector3 b) { }

	public float DistanceSquared(Vector3 b) { }

	public float DistanceSquared2(Vector3 b) { }

	public float DistanceSquared2(Vector2 b) { }

	public float Dot(Vector3 with) { }

	public static float Dot(Vector3 a, Vector3 b) { }

	public override bool Equals(Vector3 other) { }

	public virtual bool Equals(object obj) { }

	public Vector3 Flip(bool inverseYAxis = true) { }

	public float get_Magnitude() { }

	public float get_MagnitudeSquared() { }

	public float get_Rotation() { }

	public float get_SimToDispRotation() { }

	public virtual int GetHashCode() { }

	public Vector3 GetOffsetFromRadius(BufferedRandom random, float radius) { }

	public static Vector3 Lerp(Vector3 from, Vector3 to, float t) { }

	public static Vector3 MoveTowards(Vector3 from, Vector3 to, float speed) { }

	public void Normalize() { }

	public Vector3 Normalized() { }

	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	public static bool op_Equality(Vector3 a, Vector3 b) { }

	public static bool op_Inequality(Vector3 a, Vector3 b) { }

	public static Vector3 op_Multiply(Vector3 a, Vector3 b) { }

	public static Vector3 op_Multiply(Vector3 a, float value) { }

	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	public void RandomOffsetFromRadius(BufferedRandom random, float radius) { }

	public void Rotate(float degrees) { }

	public void RotateByQuaternion(Quaternion quaternion) { }

	public static Vector3 RotateTowards(Vector3 from, Vector3 to, float speed, float maxMagnitudeDelta) { }

	public Vector3 ToDisplaySpace(bool transformByCamera, float cameraOverride) { }

	public Vector3 ToSimulationSpace(bool transformByCamera, float cameraOverride) { }

	public Vector3 ToUnity() { }

	public Vector3 ToUnityDisplay() { }

	public Vector2 ToVector2() { }

}

