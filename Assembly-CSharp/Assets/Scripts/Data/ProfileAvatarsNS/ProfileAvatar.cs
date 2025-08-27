namespace Assets.Scripts.Data.ProfileAvatarsNS;

public class ProfileAvatar : AssetChangeItem, IStoreItemChange, IProfileItem
{
	public SpriteReference icon; //Field offset: 0x20
	public string trophyStoreId; //Field offset: 0x28
	public string iapStoreItemKey; //Field offset: 0x30
	public ProfileItemType profileItemType; //Field offset: 0x38
	public string customUnlockInfoLocKey; //Field offset: 0x40
	public string unlockPlayScene; //Field offset: 0x48

	public override string IapStoreItemKey
	{
		 get { } //Length: 5
	}

	public override ProfileItemType ProfileItemType
	{
		 get { } //Length: 4
	}

	public override string TrophyStoreId
	{
		 get { } //Length: 5
	}

	public ProfileAvatar() { }

	public override string get_IapStoreItemKey() { }

	public override ProfileItemType get_ProfileItemType() { }

	public override string get_TrophyStoreId() { }

}

