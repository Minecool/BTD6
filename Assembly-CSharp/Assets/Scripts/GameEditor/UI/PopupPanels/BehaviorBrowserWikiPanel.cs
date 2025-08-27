namespace Assets.Scripts.GameEditor.UI.PopupPanels;

public class BehaviorBrowserWikiPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Int32>, Int32> <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetDescription>b__23_0(KeyValuePair<String, Int32> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public BehaviorBrowserWikiPanel <>4__this; //Field offset: 0x10
		public BehaviorWikiButton wikiButton; //Field offset: 0x18
		public Type type; //Field offset: 0x20
		public GraphNodeModelDescriptorDef buttonTypeDescriptor; //Field offset: 0x28

		public <>c__DisplayClass19_0() { }

		internal void <LoadButtonAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <AnalyzeModels>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public List<TowerModel> model; //Field offset: 0x28
		public BehaviorBrowserWikiPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter<ModelDataCollector> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadButtonAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BehaviorBrowserWikiPanel <>4__this; //Field offset: 0x20
		private <>c__DisplayClass19_0 <>8__1; //Field offset: 0x28
		public int index; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnShowTriggered>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BehaviorBrowserWikiPanel <>4__this; //Field offset: 0x28
		public GraphPort graphPort; //Field offset: 0x30
		public Action<GraphPort, GraphNodeModelDescriptorDef> onCreateGraphNode; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PopulateButtonsAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BehaviorBrowserWikiPanel <>4__this; //Field offset: 0x20
		private int <currentIndex>5__2; //Field offset: 0x28
		private List<Task> <loadingTasks>5__3; //Field offset: 0x30
		private TaskAwaiter<Task> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class BehaviorUsageInfo
	{
		[CompilerGenerated]
		private int <TotalCount>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Dictionary<String, Int32> <CoOccurrence>k__BackingField; //Field offset: 0x18

		public Dictionary<String, Int32> CoOccurrence
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public int TotalCount
		{
			[CompilerGenerated]
			 get { } //Length: 94
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public BehaviorUsageInfo() { }

		[CompilerGenerated]
		public Dictionary<String, Int32> get_CoOccurrence() { }

		[CompilerGenerated]
		public int get_TotalCount() { }

		[CompilerGenerated]
		public void set_CoOccurrence(Dictionary<String, Int32> value) { }

		[CompilerGenerated]
		public void set_TotalCount(int value) { }

	}

	internal class ModelDataCollector
	{
		[CompilerGenerated]
		private Dictionary<String, BehaviorUsageInfo> <BehaviorUsage>k__BackingField; //Field offset: 0x10

		public Dictionary<String, BehaviorUsageInfo> BehaviorUsage
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public ModelDataCollector() { }

		public void AddBehaviorUsage(string behaviorName, List<String> coOccurringBehaviors) { }

		[CompilerGenerated]
		public Dictionary<String, BehaviorUsageInfo> get_BehaviorUsage() { }

		[CompilerGenerated]
		public void set_BehaviorUsage(Dictionary<String, BehaviorUsageInfo> value) { }

	}

	internal class ModelTraverser
	{
		[CompilerGenerated]
		private struct <TraverseTowerModelsAsync>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<ModelDataCollector> <>t__builder; //Field offset: 0x8
			public List<TowerModel> models; //Field offset: 0x20
			public ModelTraverser <>4__this; //Field offset: 0x28
			private int <count>5__2; //Field offset: 0x30
			private Enumerator<TowerModel> <>7__wrap2; //Field offset: 0x38
			private YieldAwaiter <>u__1; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private ModelDataCollector dataCollector; //Field offset: 0x10

		public ModelTraverser() { }

		private IEnumerable<Model> GetBehaviors(Model model) { }

		private void TraverseModel(Model model) { }

		[AsyncStateMachine(typeof(<TraverseTowerModelsAsync>d__1))]
		public Task<ModelDataCollector> TraverseTowerModelsAsync(List<TowerModel> models) { }

	}

	internal sealed class OnHidePanelEvent : MulticastDelegate
	{

		public OnHidePanelEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnShowPanelEvent : MulticastDelegate
	{

		public OnShowPanelEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GraphPort graphPort, Action<GraphPort, GraphNodeModelDescriptorDef> callback, AsyncCallback __callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GraphPort graphPort, Action<GraphPort, GraphNodeModelDescriptorDef> callback) { }

	}

	public Button createBtn; //Field offset: 0x20
	public Button cancelBtn; //Field offset: 0x28
	public GameObject buttonPrefab; //Field offset: 0x30
	public Transform buttonContainer; //Field offset: 0x38
	public ScrollRect scrollRect; //Field offset: 0x40
	public NK_TextMeshProUGUI titleText; //Field offset: 0x48
	public NK_TextMeshProUGUI descriptionText; //Field offset: 0x50
	public NK_TextMeshProUGUI countText; //Field offset: 0x58
	private readonly List<BehaviorWikiButton> buttonPool; //Field offset: 0x60
	public int maxConcurrentLoads; //Field offset: 0x68
	private Action<GraphPort, GraphNodeModelDescriptorDef> onCreateGraphNode; //Field offset: 0x70
	private GraphPort graphPort; //Field offset: 0x78
	private Type previousType; //Field offset: 0x80
	private GraphNodeModelDescriptorDef selectedDescriptor; //Field offset: 0x88

	public BehaviorBrowserWikiPanel() { }

	[AsyncStateMachine(typeof(<AnalyzeModels>d__17))]
	public void AnalyzeModels(List<TowerModel> model) { }

	public void Awake() { }

	private string GetDescription(BehaviorWikiButton button, Type type, GraphNodeModelDescriptorDef descriptor) { }

	private string GetParameterDescription(ParameterInfo parameter) { }

	[AsyncStateMachine(typeof(<LoadButtonAsync>d__19))]
	private Task LoadButtonAsync(int index) { }

	private void OnCreateTypeSelected() { }

	private void OnHideTriggered() { }

	[AsyncStateMachine(typeof(<OnShowTriggered>d__16))]
	private void OnShowTriggered(GraphPort graphPort, Action<GraphPort, GraphNodeModelDescriptorDef> onCreateGraphNode) { }

	private void OnTypeSelected(BehaviorWikiButton button, Type type, GraphNodeModelDescriptorDef descriptor) { }

	[AsyncStateMachine(typeof(<PopulateButtonsAsync>d__18))]
	private Task PopulateButtonsAsync() { }

}

