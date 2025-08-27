namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierForTag : DamageModifier
{
	public DamageModifierForTagModel damageModifierForTagModel; //Field offset: 0x68

	public DamageModifierForTag() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual float GetDamageMultiplier(Bloon bloon) { }

	public virtual bool GetMaxDamageOverride() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

