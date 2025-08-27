namespace Assets.Scripts.Data.ProfileAvatarsNS;

public interface IProfileItem
{

	public string IapStoreItemKey
	{
		 get { } //Length: 0
	}

	public ProfileItemType ProfileItemType
	{
		 get { } //Length: 0
	}

	public string TrophyStoreId
	{
		 get { } //Length: 0
	}

	public string get_IapStoreItemKey() { }

	public ProfileItemType get_ProfileItemType() { }

	public string get_TrophyStoreId() { }

}

