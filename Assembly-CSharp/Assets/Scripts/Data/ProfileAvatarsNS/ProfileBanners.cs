namespace Assets.Scripts.Data.ProfileAvatarsNS;

public class ProfileBanners : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <FirstOrDefault>b__0(ProfileBanner o) { }

	}

	[SerializeField]
	private List<ProfileBanner> profileBanners; //Field offset: 0x18
	[SerializeField]
	private ProfileBanner defaultBanner; //Field offset: 0x20

	public IEnumerable<ProfileBanner> Banners
	{
		 get { } //Length: 5
	}

	public ProfileBanner DefaultBanner
	{
		 get { } //Length: 5
	}

	public ProfileBanners() { }

	public ProfileBanner FirstOrDefault(string id) { }

	public IEnumerable<ProfileBanner> get_Banners() { }

	public ProfileBanner get_DefaultBanner() { }

}

