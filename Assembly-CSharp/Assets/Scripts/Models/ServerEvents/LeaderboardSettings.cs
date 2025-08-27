namespace Assets.Scripts.Models.ServerEvents;

public class LeaderboardSettings
{
	public TimeSpan cacheLife; //Field offset: 0x10
	public TimeSpan graceTime; //Field offset: 0x18
	public bool useLinkLeaderboardsOnly; //Field offset: 0x20
	public LeaderboardDisplaySettings display; //Field offset: 0x28
	public bool linkSupportsAscendingModifiers; //Field offset: 0x30

	public LeaderboardSettings() { }

}

