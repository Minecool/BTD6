namespace Assets.Scripts.Models.Profile;

public class MutatorSaveDataModel
{
	public string mutatorSaveId; //Field offset: 0x10
	public ObjectId towerId; //Field offset: 0x18
	public int framesLeft; //Field offset: 0x1C
	public int counter; //Field offset: 0x20
	public int roundsLeft; //Field offset: 0x24

	public MutatorSaveDataModel() { }

}

