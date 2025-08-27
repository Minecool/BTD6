namespace Assets.Scripts.Unity.UI_New;

public class DebugCollapsableTowerOutputPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<DebugCollapsableOutputPanel> <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CreateCollapsableOutputPanel>b__20_0(DebugCollapsableOutputPanel x) { }

	}

	public NK_TextMeshProUGUI headerTxt; //Field offset: 0x20
	public NK_TextMeshProUGUI detailsTxt; //Field offset: 0x28
	public GameObject plusObj; //Field offset: 0x30
	public GameObject minusObj; //Field offset: 0x38
	public Button toggleBtn; //Field offset: 0x40
	public GameObject towerDebugPanelPrefab; //Field offset: 0x48
	public GameObject towerOutputDetailsContent; //Field offset: 0x50
	private List<DebugCollapsableOutputPanel> collapsablePanelList; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsUnused>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0x61

	public bool IsUnused
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DebugCollapsableTowerOutputPanel() { }

	[CompilerGenerated]
	private void <Awake>b__16_0() { }

	public void Awake() { }

	public void CreateCollapsableOutputPanel(string title, string details) { }

	[CompilerGenerated]
	public bool get_IsUnused() { }

	[CompilerGenerated]
	public bool get_IsVisible() { }

	public void Initialise(string title, string details, bool reopenClosedPanels) { }

	private void OnSetDefaultState() { }

	private void OnToggleButton() { }

	public void PreUpdate() { }

	[CompilerGenerated]
	public void set_IsUnused(bool value) { }

	[CompilerGenerated]
	public void set_IsVisible(bool value) { }

}

