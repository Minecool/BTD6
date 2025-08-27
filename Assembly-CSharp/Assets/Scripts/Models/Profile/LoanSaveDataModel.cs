namespace Assets.Scripts.Models.Profile;

public class LoanSaveDataModel
{
	public ObjectId towerId; //Field offset: 0x10
	public int inputId; //Field offset: 0x14
	public float amount; //Field offset: 0x18
	public float collectionRate; //Field offset: 0x1C

	public LoanSaveDataModel() { }

}

