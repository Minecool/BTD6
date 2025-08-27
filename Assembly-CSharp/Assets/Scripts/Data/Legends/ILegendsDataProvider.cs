namespace Assets.Scripts.Data.Legends;

public interface ILegendsDataProvider
{

	public LegendsDataModel LegendsData
	{
		 get { } //Length: 0
	}

	public RogueGameSaveData RogueSaveData
	{
		 get { } //Length: 141
	}

	public LegendsDataModel get_LegendsData() { }

	public RogueGameSaveData get_RogueSaveData() { }

}

