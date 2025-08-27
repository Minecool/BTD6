namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnAbilityUsedTrigger : EntityTrigger
{
	public OnAbilityUsedTriggerModel onAbilityUsedTriggerModel; //Field offset: 0x70

	public OnAbilityUsedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnAbilityActivated(Ability ability) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

