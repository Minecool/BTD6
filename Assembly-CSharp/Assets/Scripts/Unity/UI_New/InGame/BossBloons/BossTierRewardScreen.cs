namespace Assets.Scripts.Unity.UI_New.InGame.BossBloons;

public class BossTierRewardScreen : GameMenu
{
	public LootPanel lootPanel; //Field offset: 0x48
	public Button playOnBtn; //Field offset: 0x50
	public TMP_Text titleTxt; //Field offset: 0x58

	public BossTierRewardScreen() { }

	private void OnEnable() { }

	public virtual void Open(object menuData) { }

	public void PlayOnClicked() { }

}

