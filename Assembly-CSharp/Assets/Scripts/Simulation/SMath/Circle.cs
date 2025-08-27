namespace Assets.Scripts.Simulation.SMath;

public struct Circle : IEquatable<Circle>
{
	public Vector3 position; //Field offset: 0x0
	public float radius; //Field offset: 0xC

	public Circle(float radius, Vector3 position) { }

	public float Circumference() { }

	public bool Contains(Circle circle) { }

	public override bool Equals(Circle other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public bool IsPointInside(float x, float y, float z = 0) { }

	public static bool op_Equality(Circle lhs, Circle rhs) { }

	public static bool op_Inequality(Circle lhs, Circle rhs) { }

	public Vector3 PointOnCircumference(float angle) { }

}

