namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class InstaTowersMenu : MonoBehaviour
{
	private const int animationStateOpenLeft = 3; //Field offset: 0x0
	private const int animationStateClosedLeft = 2; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	private const int animationStateClosed = 0; //Field offset: 0x0
	public static InstaTowersMenu instaTowersInstance; //Field offset: 0x0
	public GameObject powerButtons; //Field offset: 0x20
	public GameObject unusedButtons; //Field offset: 0x28
	public GameObject powerButtonPrefab; //Field offset: 0x30
	public ScrollRect swipe; //Field offset: 0x38
	private readonly string visibleStateLabel; //Field offset: 0x40
	private bool useLeftSide; //Field offset: 0x48
	public Animator animator; //Field offset: 0x50
	private TowerModel baseTowerModel; //Field offset: 0x58
	private bool updateGridLayoutt; //Field offset: 0x60
	private bool rebuildTowerSet; //Field offset: 0x61
	private List<GameObject> powerUseButtons; //Field offset: 0x68
	private bool showing; //Field offset: 0x70

	public InstaTowersMenu() { }

	public void ClearButtons() { }

	protected PowerButton CreateTowerButton(PowerModel model) { }

	public void EndInstaPlacement(StandardInstaTowerButton instaButton) { }

	public GameObject GetNextButton() { }

	public void Hide() { }

	public void Initialise(bool useLeftSide) { }

	public bool InsideMenuRect(Vector2 pos) { }

	public void InstaUseFailed(StandardInstaTowerButton instaButton) { }

	public void InstaUseSuccess(StandardInstaTowerButton instaButton) { }

	public bool IsShowing() { }

	public void LoadPowers() { }

	private void MenuScrolled() { }

	public void OnEnable() { }

	private void RebuildPowers() { }

	public void SetUseLeft(bool yes) { }

	public void Show(TowerModel baseTower = null) { }

	public void StartInstaPlacement(StandardInstaTowerButton instaButton) { }

	private int TowerComp(TowerModel x, TowerModel y) { }

	public void TowerSetChanged() { }

	protected void Update() { }

	public void UpdateGridLayout() { }

}

