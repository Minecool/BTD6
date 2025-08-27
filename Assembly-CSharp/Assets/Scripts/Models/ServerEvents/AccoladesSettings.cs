namespace Assets.Scripts.Models.ServerEvents;

public class AccoladesSettings
{
	public bool showLatest; //Field offset: 0x10
	public bool canViewOverride; //Field offset: 0x11
	public TimeSpan purchaseCacheTime; //Field offset: 0x18
	public int maxReceivedPanels; //Field offset: 0x20
	public int playerPercentage; //Field offset: 0x24
	public Store[] allowedStores; //Field offset: 0x28
	[JsonProperty("accoladeStoreItems")]
	[Obsolete("Just for serialization, use accoladeStoreItems instead!")]
	public String[] accoladeStoreItemStrings; //Field offset: 0x30
	[JsonIgnore]
	public AccoladeType[] accoladeStoreItems; //Field offset: 0x38

	public AccoladesSettings() { }

	public void Validate() { }

}

