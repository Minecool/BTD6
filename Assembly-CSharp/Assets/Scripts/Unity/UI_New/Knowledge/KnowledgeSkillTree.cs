namespace Assets.Scripts.Unity.UI_New.Knowledge;

public class KnowledgeSkillTree : GameMenu
{
	public GameObject knowledgeSkillBtnPrefab; //Field offset: 0x48
	public NK_TextMeshProUGUI knowledgeSetTxt; //Field offset: 0x50
	public List<RectTransform> allPages; //Field offset: 0x58
	public float pageWidth; //Field offset: 0x60
	public float pageTurnTime; //Field offset: 0x64
	public Button pageLeftBtn; //Field offset: 0x68
	public Button pageRightBtn; //Field offset: 0x70
	public GestureSettings gestureSetting; //Field offset: 0x78
	public Animator selectedPanelAnimator; //Field offset: 0x80
	public Image selectedPanelIcon; //Field offset: 0x88
	public NK_TextMeshProUGUI selectedPanelTitleTxt; //Field offset: 0x90
	public NK_TextMeshProUGUI selectedPanelDescTxt; //Field offset: 0x98
	public NK_TextMeshProUGUI selectedPanelPrereqTxt; //Field offset: 0xA0
	public Button selectedPanelAddPointsBtn; //Field offset: 0xA8
	public GameObject selectedPanelMMObj; //Field offset: 0xB0
	public NK_TextMeshProUGUI selectedPanelMMTxt; //Field offset: 0xB8
	public List<ScrollRect> scrollRects; //Field offset: 0xC0
	public List<GameObject> scrollers; //Field offset: 0xC8
	public float selectedPanelIconHeight; //Field offset: 0xD0
	public float selectedPanelAnimTime; //Field offset: 0xD4
	public Button debugTurnOnBtn; //Field offset: 0xD8
	public Button debugAddPointBtn; //Field offset: 0xE0
	public Button debugRemovePointBtn; //Field offset: 0xE8
	public Button debugForceAddSkillPointBtn; //Field offset: 0xF0
	public Button debugRemoveSkillPointBtn; //Field offset: 0xF8
	public Button debugAddAllBtn; //Field offset: 0x100
	public Button debugRemoveAllBtn; //Field offset: 0x108
	public Button debugAddSetBtn; //Field offset: 0x110
	public Button debugRemoveSetBtn; //Field offset: 0x118
	public AudioClip activateSound; //Field offset: 0x120
	public AudioClip click3Sound; //Field offset: 0x128
	public AudioClip return1Sound; //Field offset: 0x130
	private bool initialized; //Field offset: 0x138
	private List<KnowledgeSkillBtn> allSkillBtns; //Field offset: 0x140
	private KnowledgeSkillBtn currSelectedBtn; //Field offset: 0x148
	public int currPage; //Field offset: 0x150
	private int numPages; //Field offset: 0x154
	private float pageStartPos; //Field offset: 0x158
	private float pagePos; //Field offset: 0x15C
	private float pageTimer; //Field offset: 0x160
	private bool pageTurned; //Field offset: 0x164
	private TouchGesture touch; //Field offset: 0x168
	private IEnumerator swipeCoroutine; //Field offset: 0x170
	private List<String> setTitles; //Field offset: 0x178
	private float selPanelAnimTimer; //Field offset: 0x180
	private float startVerticalPos; //Field offset: 0x184
	private float desiredVerticalPos; //Field offset: 0x188
	private bool wasAVerticalAnim; //Field offset: 0x18C

	public KnowledgeSkillTree() { }

	[CompilerGenerated]
	private void <OnEnable>b__48_0() { }

	[CompilerGenerated]
	private void <OnEnable>b__48_1() { }

	[CompilerGenerated]
	private void <OnEnable>b__48_2(GameObject x) { }

	private void AddPointClicked() { }

	private void BackgroundClicked() { }

	private void BtnClicked(KnowledgeSkillBtn btn) { }

	public Transform FindGranchild(Transform aParent, string aName) { }

	private void GamepadSelectFirst() { }

	private Selectable GetFirst() { }

	private void OnBeginDrag() { }

	public void OnDisable() { }

	private void OnEnable() { }

	public virtual void Open(object data) { }

	private void PageLeft() { }

	private void PageRight() { }

	private void PositionPages(float pos) { }

	private void ReplaceIconsWithSkillBtns() { }

	public void ShowPage(int number) { }

	private void UnselectSkill() { }

	private void Update() { }

	private void UpdateButtonStates() { }

	private void UpdateSelectedSkill() { }

}

