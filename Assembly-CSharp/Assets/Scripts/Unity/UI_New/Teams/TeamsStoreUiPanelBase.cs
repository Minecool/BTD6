namespace Assets.Scripts.Unity.UI_New.Teams;

public abstract class TeamsStoreUiPanelBase : MonoBehaviour
{
	private const float maxDoubleClickSecs = 0.5; //Field offset: 0x0
	public Image icon; //Field offset: 0x20
	public Image disabledIcon; //Field offset: 0x28
	public TMP_Text shortName; //Field offset: 0x30
	public TMP_Text price; //Field offset: 0x38
	public GameObject standardFrame; //Field offset: 0x40
	public GameObject boughtFrame; //Field offset: 0x48
	public GameObject disabledFrame; //Field offset: 0x50
	public GameObject selected; //Field offset: 0x58
	public GameObject costContainer; //Field offset: 0x60
	public GameObject contributionGameObject; //Field offset: 0x68
	public GameObject fundedGameObject; //Field offset: 0x70
	public GameObject isNewGameObject; //Field offset: 0x78
	public GameObject hasChangedGameObject; //Field offset: 0x80
	public Button button; //Field offset: 0x88
	public Image fillBar; //Field offset: 0x90
	public Animator contributionAnimator; //Field offset: 0x98
	private TeamsStoreItem teamsStoreItem; //Field offset: 0xA0
	public bool isUseable; //Field offset: 0xA8
	public bool isEnabled; //Field offset: 0xA9
	public bool isSelected; //Field offset: 0xAA
	public bool isNew; //Field offset: 0xAB
	public bool hasChanged; //Field offset: 0xAC
	private int cappedContribution; //Field offset: 0xB0
	[CompilerGenerated]
	private string <ContributionId>k__BackingField; //Field offset: 0xB8
	private TeamsStoreScreen teamsStoreScreen; //Field offset: 0xC0
	private CTRelicManagerPopupScreen ctRelicManagerPopupScreen; //Field offset: 0xC8
	protected int itemPrice; //Field offset: 0xD0
	private float lastClickTime; //Field offset: 0xD4

	public int CappedContribution
	{
		 get { } //Length: 7
	}

	public private string ContributionId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public int ItemPrice
	{
		 get { } //Length: 7
	}

	public TeamsStoreItem TeamsStoreItem
	{
		 get { } //Length: 8
	}

	protected TeamsStoreUiPanelBase() { }

	public override void Bind(TeamsStoreItem teamsStoreItem, CTRelicManagerPopupScreen ctRelicManagerPopupScreen) { }

	public override void Bind(TeamsStoreItem teamsStoreItem, TeamsStoreScreen teamsStoreScreen, int itemPrice, string contributionId = null) { }

	public int get_CappedContribution() { }

	[CompilerGenerated]
	public string get_ContributionId() { }

	public int get_ItemPrice() { }

	public TeamsStoreItem get_TeamsStoreItem() { }

	public SpriteReference IconReference(out bool isRelicIcon) { }

	private void OnCTRelicSelected() { }

	private void OnSelected() { }

	[CompilerGenerated]
	private void set_ContributionId(string value) { }

	public override void SetCurrentContribution(int currentContribution, bool updateUi = true) { }

	public override void SetCurrentInfo(bool isUseable, bool isEnabled, int currentContribution) { }

	public override void SetHasChanged(bool hasChanged) { }

	public override void SetIsEnabled(bool isEnabled) { }

	public override void SetIsNew(bool isNew) { }

	public override void SetIsUseable(bool isUseable) { }

	public override void SetSelected(bool isSelected) { }

	public override void ShowShortName(bool show) { }

	public override void UpdateUi() { }

}

