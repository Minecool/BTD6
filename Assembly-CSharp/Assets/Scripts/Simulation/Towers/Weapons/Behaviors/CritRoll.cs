namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CritRoll : WeaponBehavior
{
	private CritRollModel critRollModel; //Field offset: 0x68

	public CritRoll() { }

	public override float CritChanceOffset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public void RollForCrits(Projectile projectile) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

