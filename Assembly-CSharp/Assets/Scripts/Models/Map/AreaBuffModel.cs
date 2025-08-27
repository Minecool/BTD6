namespace Assets.Scripts.Models.Map;

public abstract class AreaBuffModel : Model
{
	public string mutatorId; //Field offset: 0x30
	public int priority; //Field offset: 0x38
	public BuffIndicatorModel buffIndicatorModel; //Field offset: 0x40
	public TowerSet[] filterInTowerSets; //Field offset: 0x48

	protected AreaBuffModel(string name, string mutatorId, int priority, BuffIndicatorModel buffIndicatorModel, TowerSet[] filterInTowerSets) { }

	public abstract BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

