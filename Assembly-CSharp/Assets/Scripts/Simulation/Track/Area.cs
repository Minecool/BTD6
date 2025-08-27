namespace Assets.Scripts.Simulation.Track;

public class Area : Mutable
{
	public AreaModel areaModel; //Field offset: 0x90
	public string name; //Field offset: 0x98
	public int oo; //Field offset: 0xA0
	public bool isActive; //Field offset: 0xA4

	public Area() { }

	public void FindIntersections(Vector2 c, float radius, List<Vector2> list) { }

	public void FindIntersections(AABB aabb, List<Vector2> list) { }

	public ObjectId GetAreaID() { }

	public AABB GetBounds() { }

	public float GetTerrainHeight() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool Intersects(Vector2 c, float radius) { }

	public bool Intersects(AABB aabb) { }

	public bool Intersects(Vector2 from, Vector2 to, ref Vector2 p0, ref Vector2 p1, ref Vector2 ip) { }

	public bool IntersectsClosest(Vector2 from, Vector2 to, ref Vector2 ip) { }

	public bool IsPointInside(Vector2 p) { }

	public void Move(Vector2 moveBy) { }

	public void Rotate(float angle) { }

	public void RotateAroundPivot(Vector2 pivotPoint, float angle, bool overrideisBlockerCheck = false) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

