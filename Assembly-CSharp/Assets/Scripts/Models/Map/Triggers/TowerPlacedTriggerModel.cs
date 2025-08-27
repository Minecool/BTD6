namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(TowerPlacedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerPlacedTriggerModel : MapTriggerModel
{
	public string towerId; //Field offset: 0x38
	public Int32[] tiers; //Field offset: 0x40
	public String[] mutatorIds; //Field offset: 0x48
	public bool mustIncludeAllMutators; //Field offset: 0x50

	public TowerPlacedTriggerModel(string name, string towerId, Int32[] tiers, String[] mutatorIds, bool mustIncludeAllMutators) { }

}

