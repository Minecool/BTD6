namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class BannerItem : ProfileItem
{
	public GameObject teamIcon; //Field offset: 0xB0
	[CompilerGenerated]
	private ProfileBanner <ProfileBanner>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private IReadOnlyDictionary<String, TeamStoreItemContributions> <TeamItemContributions>k__BackingField; //Field offset: 0xC0

	public string Id
	{
		 get { } //Length: 30
	}

	public ProfileBanner ProfileBanner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string StoreItemKey
	{
		 get { } //Length: 30
	}

	public IReadOnlyDictionary<String, TeamStoreItemContributions> TeamItemContributions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public BannerItem() { }

	public string get_Id() { }

	[CompilerGenerated]
	public ProfileBanner get_ProfileBanner() { }

	public string get_StoreItemKey() { }

	[CompilerGenerated]
	public IReadOnlyDictionary<String, TeamStoreItemContributions> get_TeamItemContributions() { }

	[CompilerGenerated]
	public void set_ProfileBanner(ProfileBanner value) { }

	[CompilerGenerated]
	public void set_TeamItemContributions(IReadOnlyDictionary<String, TeamStoreItemContributions> value) { }

	public void ShowLocked() { }

	public void ShowTeamLocked(bool isLocked) { }

}

