namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class AlternateProjectile : WeaponBehavior
{
	private AlternateProjectileModel alternateProjectileModel; //Field offset: 0x68
	private int count; //Field offset: 0x70
	private bool useAltEmission; //Field offset: 0x74
	private Emission emission; //Field offset: 0x78

	public AlternateProjectile() { }

	public virtual Emission GetEmission(Emission currentEmissionDef, bool doubleShot = false) { }

	public virtual ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

