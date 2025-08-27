namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBloonLeakedTrigger : EntityTrigger
{
	public OnBloonLeakedTriggerModel behaviorModel; //Field offset: 0x70

	public OnBloonLeakedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(Bloon bloon, float livesBefore, float livesAfter, float manaShieldBefore, float manaShieldAfter) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

