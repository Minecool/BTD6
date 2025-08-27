namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class EjectEffect : WeaponBehavior
{
	public EjectEffectModel ejectEffectModel; //Field offset: 0x68
	public float scaleOverride; //Field offset: 0x70
	private Attack mainAttack; //Field offset: 0x78

	public EjectEffect() { }

	protected override PrefabReference GetAssetId() { }

	protected override float GetAssetLifespan() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

