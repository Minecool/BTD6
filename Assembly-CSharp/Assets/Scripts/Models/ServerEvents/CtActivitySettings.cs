namespace Assets.Scripts.Models.ServerEvents;

public class CtActivitySettings : EnableFlag
{
	public bool showAll; //Field offset: 0x18
	public TimeSpan refreshTimeOut; //Field offset: 0x20
	public TimeSpan autoRefreshInterval; //Field offset: 0x28
	public TimeSpan reportInterval; //Field offset: 0x30

	public CtActivitySettings() { }

}

