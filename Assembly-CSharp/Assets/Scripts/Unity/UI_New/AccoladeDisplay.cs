namespace Assets.Scripts.Unity.UI_New;

public class AccoladeDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private struct <AnimateIconLoopAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladeDisplay <>4__this; //Field offset: 0x20
		public float duration; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Transform iconContainer; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI countText; //Field offset: 0x28
	[SerializeField]
	private GameObject hasGiftedObj; //Field offset: 0x30
	[SerializeField]
	private Button hoverBtn; //Field offset: 0x38
	private bool animateIcon; //Field offset: 0x40
	private GameObject icon; //Field offset: 0x48
	[HideInInspector]
	public Animator iconAnim; //Field offset: 0x50

	public AccoladeDisplay() { }

	[CompilerGenerated]
	private void <CreateIcon>b__9_0(AsyncOperationHandle<GameObject> handle) { }

	public void AnimateIconLoop() { }

	[AsyncStateMachine(typeof(<AnimateIconLoopAsync>d__13))]
	private Task AnimateIconLoopAsync(float duration) { }

	private void Awake() { }

	private AsyncOperationHandle<GameObject> CreateIcon(PrefabReference prefab) { }

	public void Initialize(AccoladeType accoladeType, int quantity, bool hasGifted, bool animateIcon = false) { }

	private void OnEnable() { }

	private void OnHover(BaseEventData eventData) { }

}

