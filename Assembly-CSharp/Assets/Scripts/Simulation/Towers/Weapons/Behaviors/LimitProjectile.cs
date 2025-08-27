namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class LimitProjectile : WeaponBehavior
{
	public LimitProjectileModel limitEffectModel; //Field offset: 0x68
	private int limitEmissionUntilTime; //Field offset: 0x70

	public LimitProjectile() { }

	public void CreateEmissionDelay() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsCounted(ProjectileBehavior behavior) { }

	private bool IsEmissionLimitedByTime(int projectileCount) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

