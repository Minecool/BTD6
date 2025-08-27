namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DamageOverTimeForTag : DamageOverTime
{
	public DamageOverTimeForTagModel damageOverTimeForTagModel; //Field offset: 0x80

	public DamageOverTimeForTag() { }

	protected virtual void DealDamage() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

