namespace Assets.Scripts.Unity.UI_New.LevelUp;

public class LevelUpScreen : GameMenu
{
	internal enum LevelUpType
	{
		Knowledge = 0,
		TowerUnlock = 1,
		HeroUnlock = 2,
		MonkeyMoney = 3,
	}

	public NK_TextMeshProUGUI nextLevelNumber; //Field offset: 0x48
	public Image rankImg; //Field offset: 0x50
	public Sprite veteranRankSprite; //Field offset: 0x58
	public AudioClip playerLevelUpSound; //Field offset: 0x60
	public GameObject DEBUGSetXpToLevelBtn; //Field offset: 0x68

	public LevelUpScreen() { }

	public virtual void Open(object data) { }

	public void OpenNextUnlockScreen() { }

}

