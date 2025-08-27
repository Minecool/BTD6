namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(TowerInAreaTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerInAreaTriggerModel : MapTriggerModel
{
	public AreaModel areaModel; //Field offset: 0x38
	public string towerId; //Field offset: 0x40
	public Int32[] tiers; //Field offset: 0x48
	public String[] mutatorIds; //Field offset: 0x50
	public bool mustIncludeAllMutators; //Field offset: 0x58

	public TowerInAreaTriggerModel(string name, AreaModel areaModel, string towerId, Int32[] tiers, String[] mutatorIds, bool mustIncludeAllMutators) { }

}

