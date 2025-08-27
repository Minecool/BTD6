namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ZigZag : ProjectileBehavior
{
	public ZigZagModel zigZagModel; //Field offset: 0x68
	private bool zigLeft; //Field offset: 0x70
	private float currentOffset; //Field offset: 0x74

	public ZigZag() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

