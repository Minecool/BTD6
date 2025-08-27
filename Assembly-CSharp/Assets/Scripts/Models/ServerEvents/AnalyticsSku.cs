namespace Assets.Scripts.Models.ServerEvents;

public class AnalyticsSku
{
	public bool ignoreHkxr; //Field offset: 0x10
	public TimeSpan disabledPeriod; //Field offset: 0x18
	public AnalyticsDamage damage; //Field offset: 0x20
	public int eventRetries; //Field offset: 0x28
	public bool useMultiEndpoint; //Field offset: 0x2C
	public List<String> serverUrls; //Field offset: 0x30
	public bool sendUpgradeUnit; //Field offset: 0x38
	public bool sendMadeT5; //Field offset: 0x39
	public bool sendActivatedAbility; //Field offset: 0x3A

	public AnalyticsSku() { }

}

