namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class ChangeProjectilePerEmit : WeaponBehavior
{
	private ChangeProjectilePerEmitModel changeProjectilePerEmitModel; //Field offset: 0x68
	private int currentCount; //Field offset: 0x70
	private AirUnit airUnit; //Field offset: 0x78
	private Entity effectBeforeChangedProjectile; //Field offset: 0x80

	public ChangeProjectilePerEmit() { }

	public virtual ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateEffect() { }

}

