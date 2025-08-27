namespace Assets.Scripts.Unity.Map.Triggers;

public class TowerPlacedTrigger : MapTrigger
{
	private TowerPlacedTriggerModel def; //Field offset: 0x20
	public string towerId; //Field offset: 0x28
	public Int32[] tiers; //Field offset: 0x30
	public String[] mutatorIds; //Field offset: 0x38
	public bool mustIncludeAllMutators; //Field offset: 0x40

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 237
	}

	public TowerPlacedTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

