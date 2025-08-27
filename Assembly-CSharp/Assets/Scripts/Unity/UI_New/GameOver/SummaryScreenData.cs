namespace Assets.Scripts.Unity.UI_New.GameOver;

public class SummaryScreenData
{
	public LootSet lootSet; //Field offset: 0x10
	public Btd6CoopGame coopGame; //Field offset: 0x18
	public List<BloonCoDData> causeOfDefeat; //Field offset: 0x20
	public RaceEvent raceEvent; //Field offset: 0x28
	public KonFuze continuePrice; //Field offset: 0x30
	public bool isFreeplay; //Field offset: 0x38
	public int finalRound; //Field offset: 0x3C
	public string victoryDifficulty; //Field offset: 0x40
	public string sceneName; //Field offset: 0x48

	public bool IsCoop
	{
		 get { } //Length: 9
	}

	public SummaryScreenData(string sceneName) { }

	public bool get_IsCoop() { }

}

