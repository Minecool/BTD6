namespace Assets.Scripts.Models.Profile;

public class FreeTowerSaveDataModel
{
	public string baseTowerID; //Field offset: 0x10
	public int charges; //Field offset: 0x18
	public string mutuallyExclusiveWith; //Field offset: 0x20
	public int priority; //Field offset: 0x28

	public FreeTowerSaveDataModel() { }

}

