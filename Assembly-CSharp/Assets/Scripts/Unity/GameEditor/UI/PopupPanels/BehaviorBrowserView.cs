namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorBrowserView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Type behaviorType; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal void <AddBehaviourLineItem>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <UpdateViewCoroutine>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BehaviorBrowserView <>4__this; //Field offset: 0x20
		private Enumerator<Type> <>7__wrap1; //Field offset: 0x28

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
		public <UpdateViewCoroutine>d__15(int <>1__state) { }

		private void <>m__Finally1() { }

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

	internal sealed class OnCloseEvent : MulticastDelegate
	{

		public OnCloseEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public TextMeshProUGUI title; //Field offset: 0x20
	public NK_TextMeshProInputField searchInputField; //Field offset: 0x28
	public Button closeButton; //Field offset: 0x30
	public Transform behaviorTransform; //Field offset: 0x38
	[CompilerGenerated]
	private BehaviorBrowserViewModel <ViewModel>k__BackingField; //Field offset: 0x40

	public private BehaviorBrowserViewModel ViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BehaviorBrowserView() { }

	[CompilerGenerated]
	private void <Initialise>b__11_0(string value) { }

	[CompilerGenerated]
	private void <Initialise>b__12_0(string value) { }

	public void AddBehaviourLineItem(Type behaviorType) { }

	public void Awake() { }

	[CompilerGenerated]
	public BehaviorBrowserViewModel get_ViewModel() { }

	public void Initialise(BehaviorViewModel behaviorViewModel, Action<BehaviorViewModel, BehaviorViewModel> onSelectedBehaviorCallback) { }

	public void Initialise(BehaviorViewModel behaviorViewModel, Action<BehaviorViewModel, BehaviorViewModel> onSelectedBehaviorCallback, VariableViewModel<T> forVaraibleViewModel) { }

	public void OnCloseTriggered() { }

	public void OnDestroy() { }

	public void OnUpdateViewTriggered() { }

	[CompilerGenerated]
	private void set_ViewModel(BehaviorBrowserViewModel value) { }

	[IteratorStateMachine(typeof(<UpdateViewCoroutine>d__15))]
	private IEnumerator UpdateViewCoroutine() { }

}

