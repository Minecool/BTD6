namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsStoreUiDailyPanel : TeamsStoreUiPanelBase
{
	public GameObject lockedGameObject; //Field offset: 0xD8
	public TMP_Text timeText; //Field offset: 0xE0
	public TMP_Text refreshesInText; //Field offset: 0xE8
	public TMP_Text unlocksInText; //Field offset: 0xF0
	public GameObject refreshesInGameObject; //Field offset: 0xF8
	public GameObject unlocksInGameObject; //Field offset: 0x100
	private DateTime unlocksAtTime; //Field offset: 0x108
	private DateTime refreshesAtTime; //Field offset: 0x110
	private bool isDailyPower; //Field offset: 0x118

	public bool IsDailyPower
	{
		 get { } //Length: 8
	}

	public bool IsLocked
	{
		 get { } //Length: 111
	}

	public TeamsStoreUiDailyPanel() { }

	public bool get_IsDailyPower() { }

	public bool get_IsLocked() { }

	public void SetIsDailyPower(bool isDailyPower) { }

	public void SetRefreshesAtTime(DateTime refreshesAtTime) { }

	public void SetUnlocksAtTime(DateTime unlocksAtTime) { }

	private void Update() { }

	public virtual void UpdateUi() { }

}

