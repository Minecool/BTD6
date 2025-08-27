namespace Assets.Scripts.Unity.UI_New;

public class CommonBackgroundScreen : MonoBehaviour
{
	[CompilerGenerated]
	private struct <_AnimateChangeBackgroundColourTint>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CommonBackgroundScreen <>4__this; //Field offset: 0x20
		public Color newColour; //Field offset: 0x28
		public float customDuration; //Field offset: 0x38
		private float <timer>5__2; //Field offset: 0x3C
		private Color <startColour>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<OverrideScreenBackground, Boolean> <>9__31_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetScreenBackground>b__31_1(OverrideScreenBackground x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public string collectionEventTheme; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <GetScreenBackground>b__0(OverrideScreenBackground x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public CommonBackgroundScreen <>4__this; //Field offset: 0x10
		public ScreenBackground bgData; //Field offset: 0x18
		public float loadStart; //Field offset: 0x20

		public <>c__DisplayClass36_0() { }

		internal void <ShowBGForMenu>g__completed|0(AsyncOperationHandle<Texture> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public CommonBackgroundScreen <>4__this; //Field offset: 0x10
		public ScreenBackground bgData; //Field offset: 0x18
		public float loadStart; //Field offset: 0x20

		public <>c__DisplayClass39_0() { }

		internal void <HideBGForMenu>b__0() { }

		internal void <HideBGForMenu>b__1() { }

		internal void <HideBGForMenu>g__completed|2(AsyncOperationHandle<Texture> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_1
	{
		public AsyncOperationHandle<Texture> h; //Field offset: 0x10
		public <>c__DisplayClass39_0 CS$<>8__locals1; //Field offset: 0x28

		public <>c__DisplayClass39_1() { }

		internal void <HideBGForMenu>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <FadeIn>d__44 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float timeAlreadyPassed; //Field offset: 0x20
		public Graphic img; //Field offset: 0x28
		public float baseAlpha; //Field offset: 0x30
		private float <duration>5__2; //Field offset: 0x34
		private float <timer>5__3; //Field offset: 0x38

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
		public <FadeIn>d__44(int <>1__state) { }

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
	private sealed class <FadeOut>d__45 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float timeAlreadyPassed; //Field offset: 0x20
		public CommonBackgroundScreen <>4__this; //Field offset: 0x28
		public Graphic img; //Field offset: 0x30
		public float baseAlpha; //Field offset: 0x38
		public Action callback; //Field offset: 0x40
		private float <duration>5__2; //Field offset: 0x48
		private float <timer>5__3; //Field offset: 0x4C

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
		public <FadeOut>d__45(int <>1__state) { }

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

	private static CommonBackgroundScreen instance; //Field offset: 0x0
	private const float transitionDuration = 0.25; //Field offset: 0x0
	private const int downSample = 2; //Field offset: 0x0
	private const int iteration = 2; //Field offset: 0x0
	[SerializeField]
	private GameObject clearObject; //Field offset: 0x20
	[SerializeField]
	private RawImage mainRawImg; //Field offset: 0x28
	[SerializeField]
	private RawImage blurRawImg; //Field offset: 0x30
	[SerializeField]
	private RawImage customBackgroundIn; //Field offset: 0x38
	[SerializeField]
	private RawImage customBackgroundOut; //Field offset: 0x40
	[SerializeField]
	private Material vignetteMat; //Field offset: 0x48
	[SerializeField]
	private Material blurMaterial; //Field offset: 0x50
	private string currShowingBG; //Field offset: 0x58
	private Camera _camera; //Field offset: 0x60
	private Coroutine fadeoutMainRawRoutine; //Field offset: 0x68
	private Coroutine fadeoutBlurRawRoutine; //Field offset: 0x70
	private RenderTexture mainRTT; //Field offset: 0x78
	private RenderTexture blurRTT; //Field offset: 0x80
	private AsyncOperationHandle<Texture> customBackgroundInHandle; //Field offset: 0x88
	private AsyncOperationHandle<Texture> customBackgroundOutHandle; //Field offset: 0xA0

	private Texture BlurSource
	{
		private get { } //Length: 42
	}

	[AsyncStateMachine(typeof(<_AnimateChangeBackgroundColourTint>d__43))]
	private Task _AnimateChangeBackgroundColourTint(Color newColour, float customDuration) { }

	private void _EnableClearObject(bool enable) { }

	private bool _IsBackgroundAnimatingOut() { }

	private void _SetBackgroundColourOverride(string menuToOverride, Color colour) { }

	private void _SetCamera(Camera camera) { }

	private void _SwitchMenus(string closingMenu, string openingMenu) { }

	public CommonBackgroundScreen() { }

	public static Task AnimateChangeBackgroundColourTint(Color newColour, float customDuration = 0.25) { }

	private void Awake() { }

	private void CreateRenderTarget(int w, int h) { }

	private static void DestroyRenderTarget(ref RenderTexture rtt) { }

	public static void EnableClearObject(bool enable) { }

	[IteratorStateMachine(typeof(<FadeIn>d__44))]
	private IEnumerator FadeIn(Graphic img, float timeAlreadyPassed, float baseAlpha = 1) { }

	[IteratorStateMachine(typeof(<FadeOut>d__45))]
	private IEnumerator FadeOut(Graphic img, float timeAlreadyPassed, Action callback, float baseAlpha = 1) { }

	private Texture get_BlurSource() { }

	private string GetMenuBackgroundNameOrTextureId(string menuName) { }

	private ScreenBackground GetScreenBackground(string menuName) { }

	private void HideBGForMenu(string closingMenu) { }

	public static bool IsBackgroundAnimatingOut() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static void SetAlpha(Graphic img, float a) { }

	public static void SetBackgroundColourOverride(string menuToOverride, Color colour) { }

	public static void SetCamera(Camera camera) { }

	private void ShowBGForMenu(string openingMenu) { }

	public static void SwitchMenus(string closingMenu, string openingMenu) { }

	private static Texture TakeSnapshotWithBlur(ref RenderTexture target, Texture source, Material blurMaterial) { }

}

