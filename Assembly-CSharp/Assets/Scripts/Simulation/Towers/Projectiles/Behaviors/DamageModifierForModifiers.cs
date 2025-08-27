namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierForModifiers : DamageModifier
{
	public DamageModifierForModifiersModel damageModifierForModifiersModel; //Field offset: 0x68

	public DamageModifierForModifiers() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

