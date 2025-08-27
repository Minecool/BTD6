namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class InstaTowerGroupMenu : RatioObject
{
	public static InstaTowerGroupMenu instance; //Field offset: 0x0
	public GameObject instaTowerGroupButtons; //Field offset: 0x20
	public GameObject instaTowerGroupButtonPrefab; //Field offset: 0x28
	public ToggleGroup toggleGroup; //Field offset: 0x30
	private List<StandardInstaTowerGroupButton> allButtons; //Field offset: 0x38
	private StandardInstaTowerGroupButton selectedInstaTowerGroupButton; //Field offset: 0x40
	private bool needsToCreateBtns; //Field offset: 0x48

	private Btd6Player Player
	{
		private get { } //Length: 7
	}

	public InstaTowerGroupMenu() { }

	public void ClearSelection() { }

	public void CreateInstaTowerGroups() { }

	private StandardInstaTowerGroupButton CreateTowerButton(TowerModel model) { }

	public void Destroy() { }

	private Btd6Player get_Player() { }

	public int GetButtonCount() { }

	public virtual void Initialise() { }

	private void InstaQuantityChanged() { }

	public void LoadInstaTowerGroups() { }

	private void OnDestroy() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void OnSelectedInstaTowerChanged() { }

	private void Update() { }

}

