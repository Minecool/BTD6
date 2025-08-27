namespace Assets.Scripts.Models.Profile;

public class PowerSaveDataModel
{
	public string powerId; //Field offset: 0x10
	public int owner; //Field offset: 0x18

	public PowerSaveDataModel() { }

	public PowerSaveDataModel Clone() { }

}

