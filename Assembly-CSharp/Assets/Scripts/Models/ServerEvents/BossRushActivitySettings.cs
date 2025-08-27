namespace Assets.Scripts.Models.ServerEvents;

public class BossRushActivitySettings
{
	public TimeSpan messageLife; //Field offset: 0x10
	public Nullable<TimeSpan> checkInterval; //Field offset: 0x18
	public int maxDisplayCount; //Field offset: 0x28

	public BossRushActivitySettings() { }

}

