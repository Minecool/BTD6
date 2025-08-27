namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierForBloonType : DamageModifier
{
	public DamageModifierForBloonTypeModel damageModifierForBloonTypeModel; //Field offset: 0x68

	public DamageModifierForBloonType() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

