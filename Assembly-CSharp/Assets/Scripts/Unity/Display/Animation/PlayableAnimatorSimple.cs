namespace Assets.Scripts.Unity.Display.Animation;

public class PlayableAnimatorSimple : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CycleCullingMode>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayableAnimatorSimple <>4__this; //Field offset: 0x20
		private AnimatorCullingMode <currentCullingMode>5__2; //Field offset: 0x28

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
		public <CycleCullingMode>d__23(int <>1__state) { }

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

	public AnimationClip animationClip; //Field offset: 0x20
	[Header("Optional (supply if not on same game object)")]
	public Animator animator; //Field offset: 0x28
	private PlayableGraph playableGraph; //Field offset: 0x30
	private AnimationPlayableOutput playableOutput; //Field offset: 0x40
	private AnimationClipPlayable playableClip; //Field offset: 0x50
	public bool randomizeSpeed; //Field offset: 0x60
	public RangeValue randomSpeedRange; //Field offset: 0x68
	public float playbackSpeed; //Field offset: 0x70
	public bool randomStartTime; //Field offset: 0x74
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x75
	public bool resetOnEnable; //Field offset: 0x76
	public bool dontPlayOnInit; //Field offset: 0x77
	[CompilerGenerated]
	private bool <QueueAnimatorEnabledDefaultState>k__BackingField; //Field offset: 0x78
	private bool played; //Field offset: 0x79

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public double NormalizedTime
	{
		 get { } //Length: 117
		 set { } //Length: 125
	}

	public private float PlaybackSpeed
	{
		 get { } //Length: 6
		private set { } //Length: 94
	}

	public bool QueueAnimatorEnabledDefaultState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public double Time
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public PlayableAnimatorSimple() { }

	[IteratorStateMachine(typeof(<CycleCullingMode>d__23))]
	private IEnumerator CycleCullingMode() { }

	public void FreezeAt(int t) { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public double get_NormalizedTime() { }

	public float get_PlaybackSpeed() { }

	[CompilerGenerated]
	public bool get_QueueAnimatorEnabledDefaultState() { }

	public double get_Time() { }

	public void Init() { }

	public void OnDestroy() { }

	public void OnEnable() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	public void set_NormalizedTime(double value) { }

	private void set_PlaybackSpeed(float value) { }

	[CompilerGenerated]
	public void set_QueueAnimatorEnabledDefaultState(bool value) { }

	public void set_Time(double value) { }

	private void Start() { }

}

