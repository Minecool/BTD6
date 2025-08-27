namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class KeepInBounds : ProjectileBehavior
{
	private const float MinX = -150; //Field offset: 0x0
	private const float MaxX = 150; //Field offset: 0x0
	private const float MinY = -116; //Field offset: 0x0
	private const float MaxY = 116; //Field offset: 0x0
	public KeepInBoundsModel keepInBoundsModel; //Field offset: 0x68

	public KeepInBounds() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

