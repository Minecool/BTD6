namespace Assets.Scripts.Models.Profile;

[Obsolete("Use ContentBrowserData instead")]
public class PlayerContents
{
	public List<String> playedIds; //Field offset: 0x10
	public List<String> favoriteIds; //Field offset: 0x18
	public List<String> upvotedIds; //Field offset: 0x20
	public List<String> wonIds; //Field offset: 0x28
	public List<String> lostIds; //Field offset: 0x30
	public List<String> created; //Field offset: 0x38
	public List<MapSaveDataModel> mapSaves; //Field offset: 0x40
	public List<String> followingPlayerIds; //Field offset: 0x48

	public PlayerContents() { }

}

