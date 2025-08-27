namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ResetAgeOnContact : ProjectileBehavior
{
	public ResetAgeOnContactModel resetAgeOnContactModel; //Field offset: 0x68

	public ResetAgeOnContact() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

