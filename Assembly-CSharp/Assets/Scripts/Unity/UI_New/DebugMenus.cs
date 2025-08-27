namespace Assets.Scripts.Unity.UI_New;

public class DebugMenus : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DebugMenus <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Initialise>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public static DebugMenus instance; //Field offset: 0x0
	public GameObject stepControls; //Field offset: 0x20
	public GameObject stats; //Field offset: 0x28
	public GameObject debugPerformanceStats; //Field offset: 0x30
	public GameObject towerOutputDetails; //Field offset: 0x38
	public GameObject firstBloonDetails; //Field offset: 0x40
	public GameObject dpsCounter; //Field offset: 0x48
	public GameObject bossDpsObj; //Field offset: 0x50
	public GameObject selectedDpsObj; //Field offset: 0x58
	public GameObject bloonCount; //Field offset: 0x60
	public GameObject towerAttackPrefab; //Field offset: 0x68
	public GameObject debugCollapsableTowerOutputPanelPrefab; //Field offset: 0x70
	public GameObject towerOutputDetailsContent; //Field offset: 0x78
	public GridLayoutGroup debugAttackToggles; //Field offset: 0x80
	public NK_TextMeshProUGUI debugText; //Field offset: 0x88
	private NK_TextMeshProUGUI debugTextBloon; //Field offset: 0x90
	private GameObject shopVertical; //Field offset: 0x98
	private BloonMenu bloonMenu; //Field offset: 0xA0
	private Animator powersMenuAnim; //Field offset: 0xA8
	private RectTransform towerDetailRect; //Field offset: 0xB0
	private RectTransform bloonDetailsRect; //Field offset: 0xB8
	public NK_TextMeshProUGUI dpsText; //Field offset: 0xC0
	public NK_TextMeshProUGUI dpsBloonText; //Field offset: 0xC8
	public NK_TextMeshProUGUI selectedDPSText; //Field offset: 0xD0

	public DebugMenus() { }

	public void Awake() { }

	[IteratorStateMachine(typeof(<Initialise>d__25))]
	public virtual IEnumerator Initialise() { }

	private void OnDestroy() { }

}

