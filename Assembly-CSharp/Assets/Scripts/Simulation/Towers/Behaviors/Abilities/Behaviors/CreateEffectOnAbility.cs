namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CreateEffectOnAbility : AbilityBehavior
{
	public CreateEffectOnAbilityModel createEffectOnAbilityModel; //Field offset: 0x68
	private Entity effect; //Field offset: 0x70

	public CreateEffectOnAbility() { }

	public virtual void Activate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SpawnEffect(int createdAt = -1) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

