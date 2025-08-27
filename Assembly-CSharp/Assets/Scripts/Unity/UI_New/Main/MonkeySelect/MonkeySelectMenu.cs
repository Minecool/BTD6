namespace Assets.Scripts.Unity.UI_New.Main.MonkeySelect;

public class MonkeySelectMenu : GameMenu
{
	private const string openTransitionName = "AnimationIndex"; //Field offset: 0x0
	private static readonly TowerSet[] TowerSets; //Field offset: 0x0
	public Animator towersBtnsAnim; //Field offset: 0x48
	public Animator monkeySelectAnim; //Field offset: 0x50
	public MonkeyButton[] towerButtons; //Field offset: 0x58
	public MonkeyGroupButton[] monkeyGroupButtons; //Field offset: 0x60
	public GestureSettings gestureSetting; //Field offset: 0x68
	public AudioClip tickSound; //Field offset: 0x70
	public AudioClip pageSound; //Field offset: 0x78
	public Button buttonLeft; //Field offset: 0x80
	public Button buttonRight; //Field offset: 0x88
	private TouchGesture touch; //Field offset: 0x90
	private IEnumerator swipeCoroutine; //Field offset: 0x98
	private List<ShopTowerDetailsModel> shopTowerDetailsModels; //Field offset: 0xA0
	private readonly List<ShopTowerDetailsModel> selectedTowers; //Field offset: 0xA8
	public int currentSet; //Field offset: 0xB0

	public List<ShopTowerDetailsModel> ShopTowerDetails
	{
		 get { } //Length: 8
	}

	private static MonkeySelectMenu() { }

	public MonkeySelectMenu() { }

	[CompilerGenerated]
	private void <Open>b__18_0() { }

	[CompilerGenerated]
	private void <Open>b__18_1() { }

	[CompilerGenerated]
	private void <Open>b__18_2() { }

	[CompilerGenerated]
	private void <Open>b__18_3() { }

	[CompilerGenerated]
	private GameObject <Open>b__18_4() { }

	public virtual void Close() { }

	public List<ShopTowerDetailsModel> get_ShopTowerDetails() { }

	public virtual void Open(object data) { }

	public virtual void ReOpen(object data) { }

	public void SwipeGesture(bool swipeLeft) { }

	public void SwitchTowerSet(TowerSet towerSet, bool swipeGesture = false) { }

	public void UpdateTowers() { }

}

