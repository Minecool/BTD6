namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class JungleVineLimitProjectile : WeaponBehavior
{
	public JungleVineLimitProjectileModel jungleVineLimitProjectileModel; //Field offset: 0x68
	private List<Int32> emissionLimitersUntilTime; //Field offset: 0x70

	public JungleVineLimitProjectile() { }

	public void AddLimiter(int displayFrames) { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateLimits() { }

}

