namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeSuperMonkey : TSMThemeCamo
{
	public GameObject oneHandContainer; //Field offset: 0xD0
	public GameObject bothHandsContainer; //Field offset: 0xD8
	public NK_TextMeshProUGUI targetTypeLeftTxt; //Field offset: 0xE0
	public Button targetLeftPrevBtn; //Field offset: 0xE8
	public Button targetLeftNextBtn; //Field offset: 0xF0
	public Button targetRightPrevBtn; //Field offset: 0xF8
	public Button targetRightNextBtn; //Field offset: 0x100
	public AudioClip targetBtnSound; //Field offset: 0x108
	public GameObject wornHeroesCapeObject; //Field offset: 0x110
	private TowerToSimulation selectedTower; //Field offset: 0x118

	public TSMThemeSuperMonkey() { }

	[CompilerGenerated]
	private void <Start>b__10_0() { }

	[CompilerGenerated]
	private void <Start>b__10_1() { }

	[CompilerGenerated]
	private void <Start>b__10_2() { }

	[CompilerGenerated]
	private void <Start>b__10_3() { }

	public virtual void InvokeButtonPress(string buttonId) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public void Start() { }

	private void TargetBtnClicked(string id) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

