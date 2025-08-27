namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class DamageUpPerAbilityActivate : WeaponBehavior
{
	public DamageUpPerAbilityActivateModel damageUpPerAbilityActivateModel; //Field offset: 0x68
	private int activations; //Field offset: 0x70
	private DamageModifierModel damageModifierModel; //Field offset: 0x78

	public DamageUpPerAbilityActivate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnAbilityActivated(Ability ability) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

