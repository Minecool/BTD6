namespace Unity.Utils;

[RequireComponent(typeof(VideoPlayer))]
public class AddressableVideoPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <FadeIn>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RawImage image; //Field offset: 0x20
		public float time; //Field offset: 0x28
		private Color <color>5__2; //Field offset: 0x2C

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
		public <FadeIn>d__11(int <>1__state) { }

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

	[SerializeField]
	private VideoClipReference videoClipReference; //Field offset: 0x20
	[SerializeField]
	private float fadeInTime; //Field offset: 0x28
	private RawImage rawImage; //Field offset: 0x30
	private VideoPlayer videoPlayer; //Field offset: 0x38
	private RenderTexture renderTexture; //Field offset: 0x40
	private AsyncOperationHandle<VideoClip> videoClipHandle; //Field offset: 0x48

	public AddressableVideoPlayer() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<FadeIn>d__11))]
	private static IEnumerator FadeIn(RawImage image, float time) { }

	private void Load(Action<AsyncOperationHandle`1<VideoClip>> onLoaded) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void Play(AsyncOperationHandle<VideoClip> handle) { }

}

