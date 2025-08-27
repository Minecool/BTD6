namespace Assets.Scripts.Models.ServerEvents;

public class CacheSettings
{
	public TimeSpan guildCacheLife; //Field offset: 0x10
	public TimeSpan guildMedalsCacheLife; //Field offset: 0x18
	public TimeSpan bankCacheLife; //Field offset: 0x20

	public CacheSettings() { }

}

