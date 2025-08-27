namespace Assets.Scripts.GameEditor.UI;

public class GameEditorView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__27_0; //Field offset: 0x8
		public static UnityAction <>9__27_1; //Field offset: 0x10
		public static UnityAction <>9__27_2; //Field offset: 0x18
		public static UnityAction <>9__27_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__27_0() { }

		internal void <Awake>b__27_1() { }

		internal void <Awake>b__27_2() { }

		internal void <Awake>b__27_3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public GameEditorView <>4__this; //Field offset: 0x10
		public GameEditorPrefabType prefabType; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <OnShowLibraryViewTriggered>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public CustomPrefabModelData data; //Field offset: 0x10
		public GameEditorView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <OnShowEntityViewTriggered>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public GameEditorView <>4__this; //Field offset: 0x10
		public BehaviorViewModel data; //Field offset: 0x18
		public Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected; //Field offset: 0x20

		public <>c__DisplayClass32_0() { }

		internal void <OnShowBehaviorBrowserPanelTriggered>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public GameEditorView <>4__this; //Field offset: 0x0
		public BehaviorViewModel data; //Field offset: 0x0
		public Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected; //Field offset: 0x0
		public VariableViewModel<T> optionalSpecificModel; //Field offset: 0x0

		public <>c__DisplayClass33_0`1() { }

		internal void <OnShowBehaviorBrowserPanelForVvmTriggered>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	internal sealed class OnShowBehaviorBrowserPanel : MulticastDelegate
	{

		public OnShowBehaviorBrowserPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel data, Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel data, Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected) { }

	}

	internal sealed class OnShowBehaviorBrowserPanelForVvm : MulticastDelegate
	{

		public OnShowBehaviorBrowserPanelForVvm`1(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel data, Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected, VariableViewModel<T> forVariableViewModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel data, Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected, VariableViewModel<T> forVariableViewModel) { }

	}

	internal sealed class OnShowEntityPanel : MulticastDelegate
	{

		public OnShowEntityPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomPrefabModelData data) { }

	}

	internal sealed class OnShowEventManagerPanel : MulticastDelegate
	{

		public OnShowEventManagerPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomPrefabModelData data) { }

	}

	internal sealed class OnShowLibraryView : MulticastDelegate
	{

		public OnShowLibraryView(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameEditorPrefabType prefabType, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameEditorPrefabType prefabType) { }

	}

	internal sealed class OnShowSettingsPanel : MulticastDelegate
	{

		public OnShowSettingsPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomPrefabModelData data) { }

	}

	internal sealed class OnShowWaypointsPanel : MulticastDelegate
	{

		public OnShowWaypointsPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomPrefabModelData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomPrefabModelData data) { }

	}

	public static GameEditorView instance; //Field offset: 0x0
	public GameObject panel; //Field offset: 0x20
	public Button actorButton; //Field offset: 0x28
	public Button settingsButton; //Field offset: 0x30
	public Button waypointsButton; //Field offset: 0x38
	public Button eventManagerButton; //Field offset: 0x40
	public Button exitBackgroundButton; //Field offset: 0x48
	[CompilerGenerated]
	private EntityView <EntityViewPanel>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GameEditorLibraryView <EntityLibraryView>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private BehaviorBrowserView <BehaviorBrowserViewPanel>k__BackingField; //Field offset: 0x60
	private GameEditorViewModel ViewModel; //Field offset: 0x68

	public private BehaviorBrowserView BehaviorBrowserViewPanel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private GameEditorLibraryView EntityLibraryView
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private EntityView EntityViewPanel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GameEditorView() { }

	public void Awake() { }

	private void ClosePanel() { }

	[CompilerGenerated]
	public BehaviorBrowserView get_BehaviorBrowserViewPanel() { }

	[CompilerGenerated]
	public GameEditorLibraryView get_EntityLibraryView() { }

	[CompilerGenerated]
	public EntityView get_EntityViewPanel() { }

	public void OnDestroy() { }

	public void OnShowBehaviorBrowserPanelForVvmTriggered(BehaviorViewModel data, Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected, VariableViewModel<T> optionalSpecificModel) { }

	private void OnShowBehaviorBrowserPanelTriggered(BehaviorViewModel data, Action<BehaviorViewModel, BehaviorViewModel> OnBehaviorSelected) { }

	private void OnShowEntityViewTriggered(CustomPrefabModelData data) { }

	public void OnShowGameEditorPopup() { }

	private void OnShowLibraryViewTriggered(GameEditorPrefabType prefabType) { }

	[CompilerGenerated]
	private void set_BehaviorBrowserViewPanel(BehaviorBrowserView value) { }

	[CompilerGenerated]
	private void set_EntityLibraryView(GameEditorLibraryView value) { }

	[CompilerGenerated]
	private void set_EntityViewPanel(EntityView value) { }

}

