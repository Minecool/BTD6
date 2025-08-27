namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorBrowserViewModel : ViewModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, String> <>9__29_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetDerivedTypes>b__29_1(Type type) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public BehaviorBrowserViewModel <>4__this; //Field offset: 0x10
		public Type baseType; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal HashSet<Type> <FindDerivedTypesAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public Type baseType; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <GetDerivedTypes>b__0(Type t) { }

	}

	[CompilerGenerated]
	private struct <FindDerivedTypesAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BehaviorBrowserViewModel <>4__this; //Field offset: 0x20
		public Type baseType; //Field offset: 0x28
		private TaskAwaiter<HashSet`1<Type>> <>u__1; //Field offset: 0x30
		private Enumerator<Type> <>7__wrap1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GenerateBehaviorLineItemModelsAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BehaviorBrowserViewModel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GenerateBehaviorLineItemModelsForVariableViewModel>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BehaviorBrowserViewModel <>4__this; //Field offset: 0x0
		public VariableViewModel<T> optionalSpecificModel; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Initialise>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BehaviorBrowserViewModel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Initialise>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public BehaviorBrowserViewModel <>4__this; //Field offset: 0x0
		public VariableViewModel<T> forVaraibleViewModel; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnBehaviorSelected : MulticastDelegate
	{

		public OnBehaviorSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BehaviorViewModel behaviorViewModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BehaviorViewModel behaviorViewModel) { }

	}

	internal sealed class OnFilterBehaviorList : MulticastDelegate
	{

		public OnFilterBehaviorList(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string filter, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string filter) { }

	}

	internal sealed class OnUpdateBrowserView : MulticastDelegate
	{

		public OnUpdateBrowserView(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private BehaviorViewModel <BehaviorViewModel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private VariableViewModel<Behavior> <OptionalSpecificModel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<Type> <BehaviorTypes>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Action<BehaviorViewModel, BehaviorViewModel> <OnSelectedBehaviorCallback>k__BackingField; //Field offset: 0x28

	public private List<Type> BehaviorTypes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private BehaviorViewModel BehaviorViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Action<BehaviorViewModel, BehaviorViewModel> OnSelectedBehaviorCallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private VariableViewModel<Behavior> OptionalSpecificModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BehaviorBrowserViewModel(BehaviorViewModel behaviorViewModel, Action<BehaviorViewModel, BehaviorViewModel> onSelectedBehaviorCallback) { }

	private void AddBehaviorViewModel(Type type) { }

	public void FilterBehaviorList(string filter) { }

	[AsyncStateMachine(typeof(<FindDerivedTypesAsync>d__27))]
	private Task FindDerivedTypesAsync(Type baseType) { }

	[AsyncStateMachine(typeof(<GenerateBehaviorLineItemModelsAsync>d__26))]
	private Task GenerateBehaviorLineItemModelsAsync() { }

	[AsyncStateMachine(typeof(<GenerateBehaviorLineItemModelsForVariableViewModel>d__25`1))]
	private Task GenerateBehaviorLineItemModelsForVariableViewModel(VariableViewModel<T> optionalSpecificModel) { }

	[CompilerGenerated]
	public List<Type> get_BehaviorTypes() { }

	[CompilerGenerated]
	public BehaviorViewModel get_BehaviorViewModel() { }

	[CompilerGenerated]
	public Action<BehaviorViewModel, BehaviorViewModel> get_OnSelectedBehaviorCallback() { }

	[CompilerGenerated]
	public VariableViewModel<Behavior> get_OptionalSpecificModel() { }

	private List<Type> GetDerivedTypes(Type baseType) { }

	[AsyncStateMachine(typeof(<Initialise>d__21`1))]
	public void Initialise(VariableViewModel<T> forVaraibleViewModel) { }

	[AsyncStateMachine(typeof(<Initialise>d__20))]
	public void Initialise() { }

	private void OnBehaviorSelectedTriggered(BehaviorViewModel selectedBehaviorViewModel) { }

	public virtual void OnDestroy() { }

	[CompilerGenerated]
	private void set_BehaviorTypes(List<Type> value) { }

	[CompilerGenerated]
	private void set_BehaviorViewModel(BehaviorViewModel value) { }

	[CompilerGenerated]
	private void set_OnSelectedBehaviorCallback(Action<BehaviorViewModel, BehaviorViewModel> value) { }

	[CompilerGenerated]
	private void set_OptionalSpecificModel(VariableViewModel<Behavior> value) { }

}

