namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyContentData
{
	public OdysseyData odysseyData; //Field offset: 0x10
	public ChallengeType challengeType; //Field offset: 0x18
	public PlayerContent playerContent; //Field offset: 0x20
	public int mapIndexSelected; //Field offset: 0x28
	public bool showShareScreen; //Field offset: 0x2C

	public OdysseyContentData(OdysseyData odysseyData = null, ChallengeType challengeType = 5, PlayerContent playerContent = null, bool showShareScreen = false, int mapIndexSelected = -1) { }

}

