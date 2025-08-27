namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierForRound : DamageModifier
{
	public DamageModifierForRoundModel damageModifierForRoundModel; //Field offset: 0x68

	public DamageModifierForRound() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

