namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RemoveDamageTypeModifier : ProjectileBehavior
{
	public RemoveDamageTypeModifierModel removeDamageTypeModifierModel; //Field offset: 0x68

	public RemoveDamageTypeModifier() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

