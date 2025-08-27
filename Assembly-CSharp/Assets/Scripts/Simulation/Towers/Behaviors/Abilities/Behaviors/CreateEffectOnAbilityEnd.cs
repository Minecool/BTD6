namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CreateEffectOnAbilityEnd : AbilityBehavior
{
	public CreateEffectOnAbilityEndModel createEffectOnAbilityEndModel; //Field offset: 0x68
	private int startedAt; //Field offset: 0x70

	public CreateEffectOnAbilityEnd() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	private void TriggerEffect() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

