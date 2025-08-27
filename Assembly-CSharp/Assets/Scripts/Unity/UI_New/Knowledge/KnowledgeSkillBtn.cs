namespace Assets.Scripts.Unity.UI_New.Knowledge;

public class KnowledgeSkillBtn : MonoBehaviour
{
	internal sealed class ClickedEventHandler : MulticastDelegate
	{

		public ClickedEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(KnowledgeSkillBtn btn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(KnowledgeSkillBtn btn) { }

	}

	public GameObject selectedEffect; //Field offset: 0x20
	public GameObject availableEffect; //Field offset: 0x28
	public Image icon; //Field offset: 0x30
	public Material purchasedMaterial; //Field offset: 0x38
	public Material lockedMaterial; //Field offset: 0x40
	public Button button; //Field offset: 0x48
	public Color lockedArrowColor; //Field offset: 0x50
	public Color purchasedArrowColor; //Field offset: 0x60
	public float animateArrowsLength; //Field offset: 0x70
	private List<Image> arrows; //Field offset: 0x78
	private string knowledgeID; //Field offset: 0x80
	private string knowledgeSet; //Field offset: 0x88
	private int tierInvestmentRequired; //Field offset: 0x90
	private KnowlegdeSkillBtnState currState; //Field offset: 0x94
	private bool selected; //Field offset: 0x98
	private float animateArrowsTimer; //Field offset: 0x9C
	[CompilerGenerated]
	private ClickedEventHandler ClickedEvent; //Field offset: 0xA0

	public event ClickedEventHandler ClickedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public KnowlegdeSkillBtnState CurrState
	{
		 get { } //Length: 7
	}

	public string KnowledgeID
	{
		 get { } //Length: 8
	}

	public string KnowledgeSet
	{
		 get { } //Length: 8
	}

	public int TierInvestmentRequired
	{
		 get { } //Length: 7
	}

	public KnowledgeSkillBtn() { }

	[CompilerGenerated]
	public void add_ClickedEvent(ClickedEventHandler value) { }

	private void BtnClicked() { }

	public void Construct(GameObject go) { }

	public KnowlegdeSkillBtnState get_CurrState() { }

	public string get_KnowledgeID() { }

	public string get_KnowledgeSet() { }

	public int get_TierInvestmentRequired() { }

	[CompilerGenerated]
	public void remove_ClickedEvent(ClickedEventHandler value) { }

	public void SetSelected(bool value) { }

	public void SetState(KnowlegdeSkillBtnState state) { }

	private void Update() { }

}

