namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SpikeScale
{
	public Entity spikeEntity; //Field offset: 0x10
	public TransformBehavior trans; //Field offset: 0x18
	public Vector3 minScale; //Field offset: 0x20
	public Vector3 maxScale; //Field offset: 0x2C
	public Vector3 endPosition; //Field offset: 0x38
	public float maxT; //Field offset: 0x44
	public float t; //Field offset: 0x48
	public int donutIndex; //Field offset: 0x4C
	public float speed; //Field offset: 0x50
	public Random random; //Field offset: 0x58

	public SpikeScale(Entity vineEntity, Vector3 minScale, Vector3 maxScale, float timeToTake, int donutIndex, Vector3 endPosition, int minSpeed, int maxSpeed) { }

	public void Destroy() { }

	public void Update() { }

}

