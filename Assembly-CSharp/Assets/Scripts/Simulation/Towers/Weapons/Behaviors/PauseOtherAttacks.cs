namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class PauseOtherAttacks : WeaponBehavior
{
	public PauseOtherAttacksModel pauseOtherAttacksModel; //Field offset: 0x68
	private List<Attack> pausedAttacks; //Field offset: 0x70
	private int lastFiredAt; //Field offset: 0x78

	public PauseOtherAttacks() { }

	private void DisableAttacks() { }

	private void EnableAttacks() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

