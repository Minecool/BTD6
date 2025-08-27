namespace Assets.Scripts.Unity.UI_New;

public class Stereoscope : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Stereoscope <>4__this; //Field offset: 0x10
		public Canvas canvas; //Field offset: 0x18

		public <>c__DisplayClass52_0() { }

		internal void <StartRenderingCanvas>b__0(GameObject _) { }

	}

	[CompilerGenerated]
	private sealed class <TrackCameraTransform>d__37 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Camera trackingCam; //Field offset: 0x20
		public Stereoscope <>4__this; //Field offset: 0x28
		private Transform <camTransform>5__2; //Field offset: 0x30

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
		public <TrackCameraTransform>d__37(int <>1__state) { }

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

	private enum Eye
	{
		Left = 0,
		Right = 1,
	}

	private const string kLogTag = "<color=#fcba03>[Stereoscope]</color>"; //Field offset: 0x0
	private const int TextureHeight = 1536; //Field offset: 0x0
	public const float PupillaryDistance = 3.2; //Field offset: 0x0
	private static Stereoscope _instance; //Field offset: 0x0
	[SerializeField]
	private Renderer monoRenderer; //Field offset: 0x20
	[SerializeField]
	private Renderer stereoRenderer; //Field offset: 0x28
	[SerializeField]
	private Renderer canvasRenderer; //Field offset: 0x30
	[SerializeField]
	private BoxCollider boxCollider; //Field offset: 0x38
	[SerializeField]
	private Transform frame; //Field offset: 0x40
	[SerializeField]
	private Transform frameExtra; //Field offset: 0x48
	private Camera _canvasCam; //Field offset: 0x50
	private RenderTexture _canvasRtt; //Field offset: 0x58
	private readonly List<Canvas> _canvasesRendering; //Field offset: 0x60
	private Camera _replacedCamera; //Field offset: 0x68
	private Transform _head; //Field offset: 0x70
	private Camera[] _eyes; //Field offset: 0x78
	private RenderTexture[] _eyeRtts; //Field offset: 0x80
	private Coroutine cameraTransformTracker; //Field offset: 0x88
	private bool firstFrameDone; //Field offset: 0x90
	private readonly Vector2[] lastTouchPos; //Field offset: 0x98
	private readonly Vector2[] touchPos; //Field offset: 0xA0
	private Rect touchRect; //Field offset: 0xA8

	public GameObject ColliderObj
	{
		 get { } //Length: 29
	}

	public static bool Exists
	{
		 get { } //Length: 99
	}

	public static Rect MapRect
	{
		 get { } //Length: 31
	}

	public static int TouchCount
	{
		 get { } //Length: 3
	}

	private void _SetCamera(Camera cam, bool trackTransformChanges) { }

	public Stereoscope() { }

	private bool AreCanvasesRendering() { }

	private void Awake() { }

	public void Configure(float zOffset, float rotation, float aspectRatio) { }

	private static void CreateRenderTarget(ref RenderTexture target, int w, int h) { }

	private static void DestroyRenderTarget(ref RenderTexture rtt) { }

	public GameObject get_ColliderObj() { }

	public static bool get_Exists() { }

	public static Rect get_MapRect() { }

	public static int get_TouchCount() { }

	public static RenderTexture GetLeftEyeRTT() { }

	private bool IsRenderingStereo() { }

	public static Vector2 LastTouchPosition(int touchId = 0) { }

	public static Vector2 LastTouchPositionNormalized(int touchId = 0) { }

	private void OnDestroy() { }

	private void OnPlayerLoaded(Btd6Player player) { }

	public static void SetCamera(Camera camera, bool trackTransformChanges = false) { }

	private void SetStereoScale(float scale) { }

	private void SetupEye(Eye eye, float aspectRatio) { }

	public void StartRenderingCanvas(Canvas canvas) { }

	private void StopRenderingCanvas(Canvas canvas) { }

	public static bool TouchBegan(int touchId = 0) { }

	public static bool TouchEnded(int touchId = 0) { }

	public static bool Touching(int touchId = 0) { }

	public static bool TouchingScreen(int touchId = 0) { }

	public static bool TouchMoved(int touchId = 0) { }

	public static Vector2 TouchPosition(int touchId = 0) { }

	public static Vector2 TouchPositionNormalized(int touchId = 0) { }

	[IteratorStateMachine(typeof(<TrackCameraTransform>d__37))]
	private IEnumerator TrackCameraTransform(Camera trackingCam) { }

	private void Update() { }

	private void UpdateVisibility(bool areCanvasesRendering, bool isRenderingStereo) { }

}

