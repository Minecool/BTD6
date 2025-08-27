namespace Assets.Scripts.Unity.UI_New.Main.DifficultySelect;

public class DifficultySelectScreen : GameMenu
{
	public LinkFriendsScoresPanel linkFriendPanel; //Field offset: 0x48

	public DifficultySelectScreen() { }

	public void OnEasyClicked() { }

	public void OnHardClicked() { }

	public void OnMediumClicked() { }

	public virtual void Open(object data) { }

	private void OpenModeSelectUi(string difficulty) { }

}

