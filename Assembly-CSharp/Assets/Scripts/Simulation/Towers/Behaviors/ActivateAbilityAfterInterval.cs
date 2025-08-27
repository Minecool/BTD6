namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ActivateAbilityAfterInterval : TowerBehavior
{
	public ActivateAbilityAfterIntervalModel activateAbilityAfterIntervalModel; //Field offset: 0x68
	public Ability ability; //Field offset: 0x70
	private int lastActivatedAt; //Field offset: 0x78

	public ActivateAbilityAfterInterval() { }

	private Ability GetAbility() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

