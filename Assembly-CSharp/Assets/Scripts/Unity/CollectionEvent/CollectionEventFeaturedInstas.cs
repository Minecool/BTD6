namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventFeaturedInstas : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadFromDataAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CollectionEventFeaturedInstas <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int numberOfFeaturedInstas = 4; //Field offset: 0x0
	public CollectionEventFeaturedInstasHelper helper; //Field offset: 0x20
	public GameObject active; //Field offset: 0x28
	public GameObject inactive; //Field offset: 0x30
	public TMP_Text changesInTimeActive; //Field offset: 0x38
	public TMP_Text changesInTimeInactive; //Field offset: 0x40
	public AudioClip selectSound; //Field offset: 0x48
	public CollectionEventFeaturedInstaIcon[] iconsActive; //Field offset: 0x50
	public CollectionEventFeaturedInstaIcon[] iconsInactive; //Field offset: 0x58
	private CollectionEventFeaturedInstaIcon currentSelection; //Field offset: 0x60
	private CollectionEventUI collectionEventUi; //Field offset: 0x68

	public CollectionEventFeaturedInstas() { }

	[AsyncStateMachine(typeof(<LoadFromDataAsync>d__13))]
	public void LoadFromDataAsync() { }

	public void OnInstaSelected(CollectionEventFeaturedInstaIcon selectedIcon) { }

	public void Process() { }

	public void Start() { }

}

