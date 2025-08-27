namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class BonusProjectileAfterInterval : WeaponBehavior
{
	public BonusProjectileAfterIntervalModel bonusProjectileAfterIntervalModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private int count; //Field offset: 0x78
	private int timeOfLastBonus; //Field offset: 0x7C

	public BonusProjectileAfterInterval() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

