namespace Assets.Scripts.Unity.UI_New.Popups;

public class AssetLibraryPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public AssetLibraryItem item; //Field offset: 0x10
		public AssetLibraryPopup <>4__this; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal void <Start>b__0(bool isOn) { }

	}

	[CompilerGenerated]
	private sealed class <FadeMusicVolume>d__39 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public float from; //Field offset: 0x24
		public float to; //Field offset: 0x28
		private float <startTime>5__2; //Field offset: 0x2C

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
		public <FadeMusicVolume>d__39(int <>1__state) { }

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
	private struct <PlayAudioClip>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AssetLibraryPopup <>4__this; //Field offset: 0x20
		public AudioClipReference clipReference; //Field offset: 0x28
		private TaskAwaiter<AudioClip> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <RotateObject>d__38 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameObject obj; //Field offset: 0x20
		public AssetLibraryPopup <>4__this; //Field offset: 0x28

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
		public <RotateObject>d__38(int <>1__state) { }

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
	private sealed class <SetupToggleGroup>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AssetLibraryPopup <>4__this; //Field offset: 0x20

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
		public <SetupToggleGroup>d__29(int <>1__state) { }

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

	private const float kMusicFadeDuration = 0.3; //Field offset: 0x0
	[SerializeField]
	private AssetLibraryItem itemPrefab; //Field offset: 0x128
	[SerializeField]
	private ToggleGroup toggleGroup; //Field offset: 0x130
	[SerializeField]
	private TMP_Dropdown filterDropdown; //Field offset: 0x138
	[SerializeField]
	private RawImage renderTarget; //Field offset: 0x140
	[SerializeField]
	private Image spriteTarget; //Field offset: 0x148
	[SerializeField]
	private RectTransform itemInfoPanel; //Field offset: 0x150
	[SerializeField]
	[Tooltip("Degrees/s")]
	private float previewRotationSpeed; //Field offset: 0x158
	[SerializeField]
	private GameObject prefabStagePrefab; //Field offset: 0x160
	[SerializeField]
	private NK_TextMeshProUGUI infoText; //Field offset: 0x168
	private BTD6AssetLibrary assetLibrary; //Field offset: 0x170
	private RenderTexture rtt; //Field offset: 0x178
	private GameObject prefabStage; //Field offset: 0x180
	private Camera prefabStageCamera; //Field offset: 0x188
	private AsyncOperationHandle<GameObject> prefabHandle; //Field offset: 0x190
	private AsyncOperationHandle<AudioClip> audioHandle; //Field offset: 0x1A8
	private Coroutine rotateCoroutine; //Field offset: 0x1C0
	private int temporaryRenderLayer; //Field offset: 0x1C8
	private float currentMusicVolume; //Field offset: 0x1CC
	[CompilerGenerated]
	private AssetType <AssetType>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private Entry<BTD6AssetFlags> <SelectedEntry>k__BackingField; //Field offset: 0x1D8

	public AssetType AssetType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private Entry<BTD6AssetFlags> SelectedEntry
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AssetLibraryPopup() { }

	private void Awake() { }

	private void CreatePrefabStage() { }

	private void DestroyPrefabStage() { }

	[IteratorStateMachine(typeof(<FadeMusicVolume>d__39))]
	private IEnumerator FadeMusicVolume(float from, float to, float duration) { }

	private void FilterChanged(int arg0) { }

	[CompilerGenerated]
	public AssetType get_AssetType() { }

	[CompilerGenerated]
	public Entry<BTD6AssetFlags> get_SelectedEntry() { }

	private void ItemToggled(AssetLibraryItem item, bool isEnabled) { }

	private void OnDestroy() { }

	private void OnPreviewObjectCreated(AsyncOperationHandle<GameObject> handle) { }

	[AsyncStateMachine(typeof(<PlayAudioClip>d__35))]
	private Task PlayAudioClip(AudioClipReference clipReference) { }

	private void PositionCameraForPreview(GameObject obj) { }

	[IteratorStateMachine(typeof(<RotateObject>d__38))]
	private IEnumerator RotateObject(GameObject obj) { }

	[CompilerGenerated]
	public void set_AssetType(AssetType value) { }

	[CompilerGenerated]
	private void set_SelectedEntry(Entry<BTD6AssetFlags> value) { }

	[IteratorStateMachine(typeof(<SetupToggleGroup>d__29))]
	private IEnumerator SetupToggleGroup() { }

	private void Start() { }

}

