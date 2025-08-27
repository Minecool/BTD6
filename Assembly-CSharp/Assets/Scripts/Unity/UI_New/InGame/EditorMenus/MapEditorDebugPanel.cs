namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorDebugPanel : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnSharedToClipboard <>9__33_0; //Field offset: 0x8
		public static OnSharedToClipboard <>9__34_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <OnExportPropPlacementDataClicked>b__34_0() { }

		internal void <OnExportToDCMDataClicked>b__33_0() { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__20 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MapEditorDebugPanel <>4__this; //Field offset: 0x20

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
		public <Initialise>d__20(int <>1__state) { }

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

	private enum EditorPanelOptions
	{
		None = 0,
		SavePanel = 1,
		LoadPanel = 2,
		TrackPanel = 3,
	}

	internal sealed class OnTriggerSaveData : MulticastDelegate
	{

		public OnTriggerSaveData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public GameObject container; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	public Button closeMenuButton; //Field offset: 0x30
	public GameObject editorPanel; //Field offset: 0x38
	public Button exportDcmDataBtn; //Field offset: 0x40
	public Button exportPropPlacementDataBtn; //Field offset: 0x48
	public Button exportAndOverwriteQuestDataBtn; //Field offset: 0x50
	public Button importSaveDataBtn; //Field offset: 0x58
	public Button showCoordinatesBtn; //Field offset: 0x60
	private bool showingDebugOutput; //Field offset: 0x68
	public Button editorButton; //Field offset: 0x70
	public GameObject editorPanelActive; //Field offset: 0x78
	public GameObject editorPanelInactive; //Field offset: 0x80
	public bool isVisible; //Field offset: 0x88
	public string animatorLabel; //Field offset: 0x90
	public int animateIn; //Field offset: 0x98
	public int animateOut; //Field offset: 0x9C

	public MapEditorDebugPanel() { }

	[CompilerGenerated]
	private void <OnTriggerExportAndOverwriteQuestDataClicked>b__37_0() { }

	private void AnimateIn() { }

	private void AnimateOut() { }

	public void Awake() { }

	private void CloseMenu() { }

	private CustomMapModel CreateExportData() { }

	public virtual void Destroy() { }

	[IteratorStateMachine(typeof(<Initialise>d__20))]
	public virtual IEnumerator Initialise() { }

	public void LostFocus() { }

	public void OnButtonClicked() { }

	public void OnCloseButtonClicked() { }

	public void OnExportAndOverwriteQuestDataBtnClicked() { }

	public void OnExportPropPlacementDataClicked() { }

	public void OnExportToDCMDataClicked() { }

	public void OnImportAndOverwriteSaveDataBtnClicked() { }

	public void OnShowCoordinatesBtnClicked() { }

	private void OnToggleDebugOutputTextClicked() { }

	public void OnTriggerExportAndOverwriteQuestDataClicked() { }

	private void OpenMenu() { }

	public void Update() { }

	private void UpdateDebugOutputText() { }

}

