namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class HealthPercentTrigger : BloonBehaviorTrigger
{
	public HealthPercentTriggerModel modl; //Field offset: 0x70
	private List<BloonBehaviorAction> actions; //Field offset: 0x78
	private int lowestHealth; //Field offset: 0x80
	private int currentSkull; //Field offset: 0x84

	public HealthPercentTrigger() { }

	public virtual void Attatched() { }

	public virtual void Damage(int amount) { }

	public int GetCurrentSkull() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBossRushKill(int totalKills) { }

	protected virtual void OnDestroy() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void Trigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

