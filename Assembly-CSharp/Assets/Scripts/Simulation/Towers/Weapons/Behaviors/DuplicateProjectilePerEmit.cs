namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class DuplicateProjectilePerEmit : WeaponBehavior
{
	private DuplicateProjectilePerEmitModel duplicateProjectilePerEmitModel; //Field offset: 0x68
	private AirUnit airUnit; //Field offset: 0x70
	private int currentCount; //Field offset: 0x78
	private Emission emission; //Field offset: 0x80
	private Entity effectBeforeChangedProjectile; //Field offset: 0x88

	public DuplicateProjectilePerEmit() { }

	public virtual ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateEffect() { }

}

