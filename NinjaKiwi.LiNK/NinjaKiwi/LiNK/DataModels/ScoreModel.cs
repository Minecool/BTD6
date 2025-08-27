namespace NinjaKiwi.LiNK.DataModels;

public class ScoreModel
{
	public string userID; //Field offset: 0x10
	public long score; //Field offset: 0x18
	public bool isNew; //Field offset: 0x20
	public string metadata; //Field offset: 0x28

	public ScoreModel() { }

}

