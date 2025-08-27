namespace Assets.Scripts.Simulation.SMath;

public class AABB
{
	public Vector2 minBounds; //Field offset: 0x10
	public Vector2 maxBounds; //Field offset: 0x18
	private Vector2 center; //Field offset: 0x20
	private float width; //Field offset: 0x28
	private float height; //Field offset: 0x2C

	public AABB(Vector2 minBounds, Vector2 maxBounds) { }

	public AABB() { }

	public bool AABBCollision(AABB aabb) { }

	public bool CircleCollision(Vector2 position, float radius) { }

	public bool CircleCollision(Circle circle) { }

	public Vector2 GetCenter() { }

	public float GetHeight() { }

	public float GetWidth() { }

	public void Recalculate() { }

}

