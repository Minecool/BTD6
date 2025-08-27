namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class BossRushBehavior : BloonBehavior
{
	public BossRushBehaviorModel rushBehaviorModel; //Field offset: 0x70
	protected BossRushManager rushManager; //Field offset: 0x78

	public BossRushBehavior() { }

	public void ApplyMutator(int totalKills, int milestoneTierFrequency) { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile, out bool preventFurtherModification) { }

	public override RushBehaviorMutator GetMutator(int totalKills, int milestoneTierFrequency) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected override void KillCountChanged(int amount) { }

	protected virtual void OnDestroy() { }

	protected override void OnKillActions() { }

	public override void OnLivesLost() { }

	protected override void OnMilestoneActions() { }

	public virtual void OnSpawn() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

