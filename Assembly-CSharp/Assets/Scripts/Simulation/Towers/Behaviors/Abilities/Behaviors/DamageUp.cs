namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class DamageUp : AbilityBehavior
{
	public DamageUpModel damageUpModel; //Field offset: 0x68

	public DamageUp() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

