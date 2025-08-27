namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AddFreeTowerAfterRounds : TowerBehavior
{
	public AddFreeTowerAfterRoundsModel addFreeTowerAfterRoundsModel; //Field offset: 0x68
	private int roundCount; //Field offset: 0x70

	public AddFreeTowerAfterRounds() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnRoundPassed(int round) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

