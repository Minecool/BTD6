namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class BurstWeaponBehavior : WeaponBehavior
{
	public BurstWeaponBehaviorModel burstWeaponBehaviorModel; //Field offset: 0x68
	private int currentCount; //Field offset: 0x70

	public BurstWeaponBehavior() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

