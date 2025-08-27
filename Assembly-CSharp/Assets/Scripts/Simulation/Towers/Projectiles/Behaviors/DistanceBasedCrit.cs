namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DistanceBasedCrit : ProjectileBehavior
{
	public DistanceBasedCritModel distanceBasedCritModel; //Field offset: 0x68
	private bool hasRolled; //Field offset: 0x70
	private bool isCrit; //Field offset: 0x71

	public DistanceBasedCrit() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

