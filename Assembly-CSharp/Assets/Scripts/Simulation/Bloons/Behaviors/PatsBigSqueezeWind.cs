namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PatsBigSqueezeWind : BloonBehavior
{
	public const float WIND_SPEED = 3.5; //Field offset: 0x0
	public PatsBigSqueezeWindModel behaviorModel; //Field offset: 0x70
	public float distanceTraveledToReturnTo; //Field offset: 0x78
	public Vector3 returnToLocation; //Field offset: 0x7C
	public int framesAtStart; //Field offset: 0x88

	public PatsBigSqueezeWind() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

