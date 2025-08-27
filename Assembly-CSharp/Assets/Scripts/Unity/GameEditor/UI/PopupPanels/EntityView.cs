namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class EntityView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public BehaviorViewModel breadcrumb; //Field offset: 0x10
		public EntityView <>4__this; //Field offset: 0x18
		public UnityAction <>9__1; //Field offset: 0x20

		public <>c__DisplayClass18_0() { }

		internal void <OnUpdateComponentView>b__0(AsyncOperationHandle<GameObject> h) { }

		internal void <OnUpdateComponentView>b__1() { }

	}

	[CompilerGenerated]
	private struct <OnBindView>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EntityView <>4__this; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnUpdateComponentView>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EntityView <>4__this; //Field offset: 0x28
		private IEnumerator<BehaviorViewModel> <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button editNameButton; //Field offset: 0x20
	public Button saveButton; //Field offset: 0x28
	public Button resetButton; //Field offset: 0x30
	public Button backButton; //Field offset: 0x38
	public Transform breadcrumbContainer; //Field offset: 0x40
	public Transform componentContainer; //Field offset: 0x48
	[CompilerGenerated]
	private EntityViewModel <EntityViewModel>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private ComponentViewBase <CurrentComponentView>k__BackingField; //Field offset: 0x58

	public private ComponentViewBase CurrentComponentView
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private EntityViewModel EntityViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public EntityView() { }

	[CompilerGenerated]
	private void <Initialise>b__15_0() { }

	[CompilerGenerated]
	private void <OnBindView>b__17_0(AsyncOperationHandle<GameObject> h) { }

	public override void Awake() { }

	[CompilerGenerated]
	public ComponentViewBase get_CurrentComponentView() { }

	[CompilerGenerated]
	public EntityViewModel get_EntityViewModel() { }

	public void Initialise(CustomPrefabModelData prefabData, Behavior behavior, bool isNewEntity = false) { }

	private bool IsComponentViewModelNameEqual(string toCompare) { }

	public void OnBackClickedCallback() { }

	public void OnBackClickedConfirmed() { }

	[AsyncStateMachine(typeof(<OnBindView>d__17))]
	public void OnBindView() { }

	public override void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnUpdateComponentView>d__18))]
	private void OnUpdateComponentView() { }

	[CompilerGenerated]
	private void set_CurrentComponentView(ComponentViewBase value) { }

	[CompilerGenerated]
	private void set_EntityViewModel(EntityViewModel value) { }

}

