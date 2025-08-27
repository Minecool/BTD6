namespace Assets.Scripts.Models.ServerEvents;

public class PlayerCacheSettings
{
	public bool isEnabled; //Field offset: 0x10
	public TimeSpan cacheLife; //Field offset: 0x18
	public TimeSpan waitTimeout; //Field offset: 0x20

	public PlayerCacheSettings() { }

}

