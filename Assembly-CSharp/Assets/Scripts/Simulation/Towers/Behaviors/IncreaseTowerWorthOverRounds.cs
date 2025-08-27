namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class IncreaseTowerWorthOverRounds : TowerBehavior
{
	public IncreaseTowerWorthOverRoundsModel increaseTowerWorthOverRoundsModel; //Field offset: 0x68
	public int originalPurchasePrice; //Field offset: 0x70

	public IncreaseTowerWorthOverRounds() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnCurrentRoundIncreased(int round) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSold(float amount) { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

