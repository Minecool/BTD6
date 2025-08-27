namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class TopScore
{
	public int score; //Field offset: 0x10
	public string LiNKID; //Field offset: 0x18
	public SpriteReference avatarSpriteReference; //Field offset: 0x20
	public ScoreDifficulty difficulty; //Field offset: 0x28

	public TopScore(int score, string LiNKID, string avatar, ScoreDifficulty difficulty) { }

}

