namespace Assets.Scripts.Unity.UI_New.Popups;

public class MapDifficultyLockPopup : Popup
{
	[SerializeField]
	private Image fill; //Field offset: 0x128
	[SerializeField]
	private NK_TextMeshProUGUI count; //Field offset: 0x130
	[SerializeField]
	private Image difficultyIcon; //Field offset: 0x138
	[SerializeField]
	private Sprite[] difficultyIcons; //Field offset: 0x140

	public MapDifficultyLockPopup() { }

	public void SetCompletion(MapDifficulty difficulty, int completed, int required) { }

}

