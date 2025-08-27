namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ExpireTowerAfterAbility : AbilityBehavior
{
	public ExpireTowerAfterAbilityModel expireTowerAfterAbilityModel; //Field offset: 0x68
	private int roundsLeft; //Field offset: 0x70
	public int framesLeft; //Field offset: 0x74

	public ExpireTowerAfterAbility() { }

	public virtual void Activate() { }

	private void CheckExpiry() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int round) { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

