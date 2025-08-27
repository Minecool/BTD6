namespace Assets.Scripts.Unity.UI_New.InGame;

public class HudController : RatioObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public HudController <>4__this; //Field offset: 0x10
		public PlayMovieClipActionModel model; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass21_0() { }

		internal void <OnPlayMovieClipTriggered>b__0(AsyncOperationHandle<GameObject> h) { }

		internal void <OnPlayMovieClipTriggered>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <HandleHandDragAnimation>d__27 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HudController <>4__this; //Field offset: 0x20
		public CreateHandDragObjectActionModel model; //Field offset: 0x28
		private HandAnimationEntity <entity>5__2; //Field offset: 0x30
		private Vector3 <startPos>5__3; //Field offset: 0x50
		private Vector3 <endPos>5__4; //Field offset: 0x5C
		private string <entityId>5__5; //Field offset: 0x68
		private Vector3 <midPos>5__6; //Field offset: 0x70
		private float <elapsed>5__7; //Field offset: 0x7C

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
		public <HandleHandDragAnimation>d__27(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <OnInGameTriggeredDialogue>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogueData dialogue; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct HandAnimationEntity
	{
		public GameObject handStart; //Field offset: 0x0
		public GameObject handEnd; //Field offset: 0x8
		public CreateHandDragObjectActionModel model; //Field offset: 0x10
		public Coroutine coroutine; //Field offset: 0x18

	}

	private struct PlacementCircle
	{
		public CreatePlacementCircleActionModel model; //Field offset: 0x0
		public GameObject placementCircle; //Field offset: 0x8

	}

	public GameObject monkeySelectAnimation3DPrefab; //Field offset: 0x20
	public GameObject monkeySelectAnimationPrefab; //Field offset: 0x28
	public GameObject placementCirclePrefab; //Field offset: 0x30
	public GameObject handDragStartPrefab; //Field offset: 0x38
	public GameObject handDragEndPrefab; //Field offset: 0x40
	private readonly Dictionary<String, PlacementCircle> placementCircles; //Field offset: 0x48
	private readonly Dictionary<String, HandAnimationEntity> handAnimations; //Field offset: 0x50
	private readonly Dictionary<String, PlayMovieClip> movieClips; //Field offset: 0x58
	private GameObject shopPanelTowerGlowObject; //Field offset: 0x60
	private bool autoStartOriginalState; //Field offset: 0x68
	private bool autoStartScriptState; //Field offset: 0x69
	private readonly float handMoveDuration; //Field offset: 0x6C
	private readonly float fadeTime; //Field offset: 0x70

	public bool IsPlayingMovieClip
	{
		 get { } //Length: 74
	}

	public HudController() { }

	private void CleanUp() { }

	public bool get_IsPlayingMovieClip() { }

	[IteratorStateMachine(typeof(<HandleHandDragAnimation>d__27))]
	private IEnumerator HandleHandDragAnimation(CreateHandDragObjectActionModel model) { }

	public void Initialize() { }

	private void OnClipEnded(PlayMovieClipActionModel model) { }

	public void OnCloseSceneTriggered(string sceneName) { }

	public void OnCreateHandDragAnimationTriggered(CreateHandDragObjectActionModel model) { }

	public void OnCreatePlacementCircleTriggered(CreatePlacementCircleActionModel model) { }

	[AsyncStateMachine(typeof(<OnInGameTriggeredDialogue>d__20))]
	public void OnInGameTriggeredDialogue(DialogueData dialogue, bool saveSeen) { }

	public void OnManageMainHudTriggered(ManageMainHudActionModel model) { }

	public void OnManageShopPanelTriggered(ManageShopPanelModel model) { }

	public void OnManageTowerHudPanelTriggered(ManageTowerUpgradesPanelActionModel model) { }

	public void OnOpenSceneTriggered(string sceneName, object metadata) { }

	public void OnPlayMovieClipTriggered(PlayMovieClipActionModel model) { }

	public virtual void OnQuitToMenu() { }

	public void OnRemoveAllHandDragObjectTriggered() { }

	public void OnRemoveAllPlacementCirclesTriggered() { }

	public void OnRemoveHandDragObjectTriggered(string id) { }

	public void OnRemovePlacementCircleTriggered(string id) { }

	public virtual void OnRestart() { }

	public void OnShowGlowOnTowerButtonTriggered(HudModifier modifier) { }

	public void OnTowerCreatedTriggered(TowerToSimulation bridgeTower) { }

}

