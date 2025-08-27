namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class VineScale
{
	public Entity vineEntity; //Field offset: 0x10
	public TransformBehavior trans; //Field offset: 0x18
	public Vector3 minScale; //Field offset: 0x20
	public Vector3 maxScale; //Field offset: 0x2C
	public float maxT; //Field offset: 0x38
	public float t; //Field offset: 0x3C
	public int donutIndex; //Field offset: 0x40

	public VineScale(Entity vineEntity, Vector3 minScale, Vector3 maxScale, float timeToTake, int donutIndex) { }

	public void Destroy() { }

	public void Update() { }

}

