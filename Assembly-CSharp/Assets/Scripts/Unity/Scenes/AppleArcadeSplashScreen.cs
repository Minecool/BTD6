namespace Assets.Scripts.Unity.Scenes;

public class AppleArcadeSplashScreen : GenericAnimatedScene
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public double ar; //Field offset: 0x10
		public int h; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal bool <GetVideo>g__FitsAspect|0(VideoRef v) { }

		internal bool <GetVideo>g__FitsHeight|1(VideoRef v) { }

	}

	[CompilerGenerated]
	private sealed class <FadeOutAndComplete>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public VideoPlayer source; //Field offset: 0x20
		public AppleArcadeSplashScreen <>4__this; //Field offset: 0x28
		private float <counter>5__2; //Field offset: 0x30

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
		public <FadeOutAndComplete>d__14(int <>1__state) { }

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

	private class VideoRef
	{
		public Vector2 aspect; //Field offset: 0x10
		public int height; //Field offset: 0x18
		public VideoClip video; //Field offset: 0x20

		public VideoRef() { }

	}

	private VideoPlayer videoPlayer; //Field offset: 0x28
	private bool userCanCancel; //Field offset: 0x30
	private bool userCancelled; //Field offset: 0x31
	private PlayerPrefInt hasSeenSplash; //Field offset: 0x38
	[SerializeField]
	private VideoRef[] videoReferences; //Field offset: 0x40

	public AppleArcadeSplashScreen() { }

	[IteratorStateMachine(typeof(<FadeOutAndComplete>d__14))]
	private IEnumerator FadeOutAndComplete(VideoPlayer source) { }

	private VideoClip GetVideo() { }

	private bool OnUserCancelled(VideoPlayer source) { }

	private void OnVideoError(VideoPlayer source, string message) { }

	private void PlayVideo(VideoPlayer source) { }

	private void SplashCompleted(VideoPlayer source) { }

	private void Start() { }

	private void StartVideo(VideoPlayer source, VideoClip videoAsset) { }

	private void TryCancel() { }

	private void Update() { }

}

