namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBossDefeatedTrigger : EntityTrigger
{
	public OnBossDefeatedTriggerModel behaviorModel; //Field offset: 0x70

	public OnBossDefeatedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(int tier) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

