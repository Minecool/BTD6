namespace Assets.Scripts.Data.ProfileAvatarsNS;

public class ProfileAvatars : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <FirstOrDefault>b__0(ProfileAvatar o) { }

	}

	public const string kDefaultAvatarId = "ProfileAvatar01"; //Field offset: 0x0
	[SerializeField]
	private List<ProfileAvatar> profileAvatars; //Field offset: 0x18
	[SerializeField]
	private ProfileAvatar defaultAvatar; //Field offset: 0x20

	public IEnumerable<ProfileAvatar> Avatars
	{
		 get { } //Length: 5
	}

	public ProfileAvatar DefaultAvatar
	{
		 get { } //Length: 5
	}

	public ProfileAvatars() { }

	public ProfileAvatar FirstOrDefault(string id) { }

	public IEnumerable<ProfileAvatar> get_Avatars() { }

	public ProfileAvatar get_DefaultAvatar() { }

}

