namespace NinjaKiwi.LiNK.DataModels;

public class ScoreListModel
{
	public ScoreModel[] above; //Field offset: 0x10
	public ScoreModel[] equal; //Field offset: 0x18
	public ScoreModel[] below; //Field offset: 0x20

	public ScoreListModel() { }

}

