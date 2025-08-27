namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBossHealedTrigger : EntityTrigger
{
	public OnBossHealedTriggerModel behaviorModel; //Field offset: 0x70

	public OnBossHealedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(int amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

