namespace Assets.Scripts.Unity.UI_New;

public class AccoladeSummaryScreenIcon : MonoBehaviour
{
	[CompilerGenerated]
	private struct <OnIconLoadedAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladeSummaryScreenIcon <>4__this; //Field offset: 0x28
		public AsyncOperationHandle<GameObject> handle; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject iconContainer; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI nameText; //Field offset: 0x28
	private GameObject positionSource; //Field offset: 0x30

	public AccoladeSummaryScreenIcon() { }

	public void Initialize(AccoladeType accoladeType, string playerName, GameObject positionSource) { }

	[AsyncStateMachine(typeof(<OnIconLoadedAsync>d__4))]
	private void OnIconLoadedAsync(AsyncOperationHandle<GameObject> handle) { }

	private void Update() { }

}

