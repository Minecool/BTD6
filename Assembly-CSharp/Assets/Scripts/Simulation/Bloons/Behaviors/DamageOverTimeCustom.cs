namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DamageOverTimeCustom : DamageOverTime
{
	public DamageOverTimeCustomModel damageOverTimeCustomModel; //Field offset: 0x80

	public DamageOverTimeCustom() { }

	protected virtual void DealDamage() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

