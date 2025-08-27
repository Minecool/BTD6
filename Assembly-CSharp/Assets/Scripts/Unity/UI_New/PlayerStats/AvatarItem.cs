namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class AvatarItem : ProfileItem
{
	[CompilerGenerated]
	private ProfileAvatar <ProfileAvatar>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private AvatarItemType <AvatarItemType>k__BackingField; //Field offset: 0xB8

	public private AvatarItemType AvatarItemType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public string Id
	{
		 get { } //Length: 30
	}

	public ProfileAvatar ProfileAvatar
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

	public AvatarItem() { }

	[CompilerGenerated]
	public AvatarItemType get_AvatarItemType() { }

	public string get_Id() { }

	[CompilerGenerated]
	public ProfileAvatar get_ProfileAvatar() { }

	public string get_StoreItemKey() { }

	[CompilerGenerated]
	private void set_AvatarItemType(AvatarItemType value) { }

	[CompilerGenerated]
	public void set_ProfileAvatar(ProfileAvatar value) { }

	public void ShowLocked() { }

	public void ShowTeamLocked(AvatarItemType itemType, bool unlocked, bool isDefaultItem = false) { }

}

