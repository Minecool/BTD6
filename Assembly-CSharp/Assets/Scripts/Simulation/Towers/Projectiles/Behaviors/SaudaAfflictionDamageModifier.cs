namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SaudaAfflictionDamageModifier : DamageModifier
{
	public SaudaAfflictionDamageModifierModel saudaAfflictionDamageModifierModel; //Field offset: 0x68

	public SaudaAfflictionDamageModifier() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

