namespace Assets.Scripts.Unity.Map.Triggers;

public class TowerInAreaTrigger : MapTrigger
{
	private TowerInAreaTriggerModel def; //Field offset: 0x20
	public Area area; //Field offset: 0x28
	public string towerId; //Field offset: 0x30
	public Int32[] tiers; //Field offset: 0x38
	public String[] mutatorIds; //Field offset: 0x40
	public bool mustIncludeAllMutators; //Field offset: 0x48

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 272
	}

	public TowerInAreaTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

