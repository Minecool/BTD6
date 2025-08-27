namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageUpPerAbilityActivateModifier : DamageModifier
{
	public DamageUpPerAbilityActivateModifierModel damageUpPerAbilityActivateModifierModel; //Field offset: 0x68
	public float bonusDamagePercent; //Field offset: 0x70

	public DamageUpPerAbilityActivateModifier() { }

	public virtual float GetDamageMultiplier(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

