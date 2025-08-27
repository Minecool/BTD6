namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MutateRemoveAllAttacksOnAbilityActivate : AbilityBehavior
{
	public MutateRemoveAllAttacksOnAbilityActivateModel myModel; //Field offset: 0x68
	private bool activated; //Field offset: 0x70
	private int endAbilityFrame; //Field offset: 0x74
	private List<Attack> pausedAttacks; //Field offset: 0x78

	public MutateRemoveAllAttacksOnAbilityActivate() { }

	public virtual void Activate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	private void PauseAttacks() { }

	private void Process(int elasped) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void UnpauseAttacks() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

