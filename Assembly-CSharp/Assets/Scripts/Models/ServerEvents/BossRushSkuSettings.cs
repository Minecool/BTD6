namespace Assets.Scripts.Models.ServerEvents;

public class BossRushSkuSettings : EnableFlag
{
	public BossRushActivitySettings activity; //Field offset: 0x18
	public TimeSpan teamJoinTimeout; //Field offset: 0x20
	public TimeSpan ingameCheckInterval; //Field offset: 0x28

	public BossRushSkuSettings() { }

}

