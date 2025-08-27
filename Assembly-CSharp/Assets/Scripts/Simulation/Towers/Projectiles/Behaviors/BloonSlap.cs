namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class BloonSlap : ProjectileBehavior
{
	public BloonSlapModel bloonSlapModel; //Field offset: 0x68
	public int maxPiercedAmount; //Field offset: 0x70
	public int piercedAmount; //Field offset: 0x74

	public BloonSlap() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

