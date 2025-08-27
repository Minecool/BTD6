namespace Assets.Scripts.Models.ServerEvents;

public class CollectablesMetadata : ThemableMetadata
{
	public bool mapBonusActive; //Field offset: 0x18
	public Dictionary<String, Boolean> featuredInstas; //Field offset: 0x20

	public CollectablesMetadata() { }

}

