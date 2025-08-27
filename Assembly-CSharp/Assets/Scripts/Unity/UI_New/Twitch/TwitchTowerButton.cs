namespace Assets.Scripts.Unity.UI_New.Twitch;

public class TwitchTowerButton : TowerImageLoader
{
	public Button clickArea; //Field offset: 0x40
	public Action<String> OnButtonClicked; //Field offset: 0x48

	public TwitchTowerButton() { }

	private void OnClick() { }

	private void Start() { }

}

