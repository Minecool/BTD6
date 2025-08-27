namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CritMultiplier : WeaponBehavior
{
	private int nextCritAt; //Field offset: 0x68
	private int current; //Field offset: 0x6C
	private CritMultiplierModel critMultiplierModel; //Field offset: 0x70

	public CritMultiplier() { }

	public virtual ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void SetNextCrit() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

