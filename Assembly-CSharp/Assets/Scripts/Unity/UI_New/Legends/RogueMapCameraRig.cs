namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueMapCameraRig : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CutScene>d__38 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RogueMapCameraRig <>4__this; //Field offset: 0x20
		public Vector3 focusOn; //Field offset: 0x28
		public float focusHeight; //Field offset: 0x34
		public IEnumerator middle; //Field offset: 0x38
		private Vector3 <savedFocus>5__2; //Field offset: 0x40
		private float <savedDist>5__3; //Field offset: 0x4C

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
		public <CutScene>d__38(int <>1__state) { }

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

	public float maxRadius; //Field offset: 0x20
	public Transform alternateCenterPoint; //Field offset: 0x28
	[SerializeField]
	private float initialHeight; //Field offset: 0x30
	[SerializeField]
	private float minHeight; //Field offset: 0x34
	[SerializeField]
	private float maxHeight; //Field offset: 0x38
	[SerializeField]
	private Camera cam; //Field offset: 0x40
	[SerializeField]
	private float focusSpeed; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve rotationAtHeight; //Field offset: 0x50
	[SerializeField]
	private AnimationCurve zoomSpeedAtHeight; //Field offset: 0x58
	private readonly PlayerPrefFloat roguemapCameraHeight; //Field offset: 0x60
	private float currDist; //Field offset: 0x68
	private Vector3 focus; //Field offset: 0x6C
	private Vector3 animStartFocus; //Field offset: 0x78
	private Vector3 animEndFocus; //Field offset: 0x84
	private float animStartDist; //Field offset: 0x90
	private float animEndDist; //Field offset: 0x94
	private float animTimer; //Field offset: 0x98
	private float animDuration; //Field offset: 0x9C
	private bool heightWasOverridden; //Field offset: 0xA0
	private int collisionMask; //Field offset: 0xA4
	[CompilerGenerated]
	private bool <IgnoreGround>k__BackingField; //Field offset: 0xA8

	public bool IgnoreGround
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public RogueMapCameraRig() { }

	private void Awake() { }

	private void ConstrainToWorldLimits() { }

	[IteratorStateMachine(typeof(<CutScene>d__38))]
	public IEnumerator CutScene(Vector3 focusOn, float focusHeight, IEnumerator middle) { }

	private void DoAnimation(float deltaTime) { }

	private float EaseInOutCubic(float t) { }

	public float FocusOn(Vector3 focusOn, float overrideHeight = 0, bool instant = false) { }

	[CompilerGenerated]
	public bool get_IgnoreGround() { }

	public void Move(Vector3 direction) { }

	private float NormalizedCamHeight() { }

	private void OnDestroy() { }

	public void PlayInitialLoadAnimation() { }

	private bool RaycastHitGround(out RaycastHit hit) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	[CompilerGenerated]
	public void set_IgnoreGround(bool value) { }

	private void Update() { }

	public Vector3 WorldToScreenPoint(Vector3 pos) { }

	public Vector3 WorldToViewportPoint(Vector3 pos) { }

	public void Zoom(float zoomAmount) { }

}

