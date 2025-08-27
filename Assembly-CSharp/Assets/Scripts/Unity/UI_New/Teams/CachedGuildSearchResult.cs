namespace Assets.Scripts.Unity.UI_New.Teams;

public struct CachedGuildSearchResult
{
	public Response teamListResponse; //Field offset: 0x0
	public TimeSpan creationTime; //Field offset: 0x8

	[IsReadOnly]
	public bool IsCurrent(TimeSpan now, TimeSpan cacheLife) { }

}

