namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierWrath : DamageModifier
{
	public DamageModifierWrathModel damageModifierWrathModel; //Field offset: 0x68

	public DamageModifierWrath() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

