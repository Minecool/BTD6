namespace Assets.Scripts.Unity.UI_New.QuestDialogueSystems;

public class QuestDialogueSystem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Action<GameObject> onComplete; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <LoadPrefab>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public QuestDialogueSystem <>4__this; //Field offset: 0x10
		public DateTime delay; //Field offset: 0x18
		public bool wait; //Field offset: 0x20

		public <>c__DisplayClass33_0() { }

		internal void <WaitForClick>b__0() { }

	}

	[CompilerGenerated]
	private struct <AsyncSceneBlockerChecks>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestDialogueSystem <>4__this; //Field offset: 0x20
		private CommonForegroundScreen <cfs>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCharacters>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestDialogueAnimData frameData; //Field offset: 0x20
		public QuestDialogueSystem <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPrefab>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Action<GameObject> onComplete; //Field offset: 0x20
		public QuestCharacter characterData; //Field offset: 0x28
		public Transform transform; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunAnimatedDialogueSequence>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogueData dialogueData; //Field offset: 0x20
		public QuestDialogueSystem <>4__this; //Field offset: 0x28
		public Action<String>[] actions; //Field offset: 0x30
		public Action completedCallback; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private int <i>5__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForClick>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestDialogueSystem <>4__this; //Field offset: 0x20
		private <>c__DisplayClass33_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private YieldAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Camera previewCamera; //Field offset: 0x20
	public GameObject backgroundTint; //Field offset: 0x28
	public GameObject leftMonkeyContainer; //Field offset: 0x30
	public GameObject rightMonkeyContainer; //Field offset: 0x38
	public NK_TextMeshProUGUI leftMonkeyNameTxt; //Field offset: 0x40
	public NK_TextMeshProUGUI rightMonkeyNameTxt; //Field offset: 0x48
	public GameObject leftMonkeyNamePanel; //Field offset: 0x50
	public GameObject rightMonkeyNamePanel; //Field offset: 0x58
	public Lightbox animatedSequenceButton; //Field offset: 0x60
	public Animator animatedSequenceAnimator; //Field offset: 0x68
	public TextRoller animatedSequenceSpeechText; //Field offset: 0x70
	public Action OnClickedInteractiveAnimatedSequence; //Field offset: 0x78
	public RenderMultipleDialogueCameraViews assetPreviewer; //Field offset: 0x80
	private Animator leftMonkeyAnimator; //Field offset: 0x88
	private Animator rightMonkeyAnimator; //Field offset: 0x90
	private GameObject leftMonkeyObject; //Field offset: 0x98
	private GameObject rightMonkeyObject; //Field offset: 0xA0
	private QuestDialogueAnimData frameData; //Field offset: 0xA8
	private string leftMonkeyId; //Field offset: 0xB0
	private string rightMonkeyId; //Field offset: 0xB8
	private string currAnimatedSequenceAnimatorID; //Field offset: 0xC0
	public GameObject view1; //Field offset: 0xC8
	public GameObject view2; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <IsRunningAnimatedInteraction>k__BackingField; //Field offset: 0xD8

	public private bool IsRunningAnimatedInteraction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public QuestDialogueSystem() { }

	[CompilerGenerated]
	private void <LoadCharacters>b__31_0(GameObject go) { }

	[CompilerGenerated]
	private void <LoadCharacters>b__31_1(GameObject go) { }

	[CompilerGenerated]
	private void <RunAnimatedDialogueSequence>b__28_0() { }

	[AsyncStateMachine(typeof(<AsyncSceneBlockerChecks>d__30))]
	private Task AsyncSceneBlockerChecks() { }

	[CompilerGenerated]
	public bool get_IsRunningAnimatedInteraction() { }

	public void Initialise() { }

	[AsyncStateMachine(typeof(<LoadCharacters>d__31))]
	private Task LoadCharacters(QuestDialogueAnimData frameData) { }

	[AsyncStateMachine(typeof(<LoadPrefab>d__32))]
	private Task LoadPrefab(QuestCharacter characterData, Transform transform, Action<GameObject> onComplete) { }

	[AsyncStateMachine(typeof(<RunAnimatedDialogueSequence>d__28))]
	public Task RunAnimatedDialogueSequence(DialogueData dialogueData, Action completedCallback, Action<String>[] actions = null) { }

	[CompilerGenerated]
	private void set_IsRunningAnimatedInteraction(bool value) { }

	private void SetCharacterAnimators() { }

	[AsyncStateMachine(typeof(<WaitForClick>d__33))]
	private Task WaitForClick() { }

}

