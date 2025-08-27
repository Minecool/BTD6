namespace Assets.Scripts.Unity.Display.Animation;

public class PlayableAnimator : MonoBehaviour, ICustomAnimator
{
	[CompilerGenerated]
	private sealed class <SwapAnimations>d__48 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public List<AnimationChange> animationChanges; //Field offset: 0x20
		public PlayableAnimator <>4__this; //Field offset: 0x28
		private Enumerator<AnimationChange> <>7__wrap1; //Field offset: 0x30
		private AnimationChange <ac>5__3; //Field offset: 0x48
		private AsyncOperationHandle<AnimationClip> <origHandle>5__4; //Field offset: 0x50
		private AsyncOperationHandle<AnimationClip> <swapHandle>5__5; //Field offset: 0x68

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
		public <SwapAnimations>d__48(int <>1__state) { }

		private void <>m__Finally1() { }

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

	private class AnimationSwapRecord
	{
		public CustomPlayableAnimationClip PAC; //Field offset: 0x10
		public AnimationClip Original; //Field offset: 0x18

		public AnimationSwapRecord() { }

	}

	[CompilerGenerated]
	private int <currentAnimationState>k__BackingField; //Field offset: 0x20
	public List<CustomPlayableAnimationClip> playableAnimationClips; //Field offset: 0x28
	private CustomPlayableAnimationClip currentAnimation; //Field offset: 0x30
	private int queuedReturnState; //Field offset: 0x38
	public Animator animator; //Field offset: 0x40
	private PlayableGraph playableGraph; //Field offset: 0x48
	private AnimationPlayableOutput playableOutput; //Field offset: 0x58
	private AnimationMixerPlayable mixerPlayable; //Field offset: 0x68
	private int blendCount; //Field offset: 0x78
	private BlendTransition blendTransition; //Field offset: 0x80
	public Action<Int32> OnLoopEvent; //Field offset: 0x88
	private float playbackSpeed; //Field offset: 0x90
	public string currentAnimationName; //Field offset: 0x98
	public bool allowOverwriteQueuedReturnState; //Field offset: 0xA0
	private List<AnimationSwapRecord> swapRecords; //Field offset: 0xA8

	public private override int currentAnimationState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int QueuedReturnState
	{
		 get { } //Length: 4
	}

	public PlayableAnimator() { }

	private void CreatePlayable(AnimationBakerStateConfig config) { }

	private void CreatePlayable(CustomAnimationClipConfig config) { }

	private void CreatePlayable(AnimationClip animationClip) { }

	private void CreatePlayables(List<AnimationBakerStateConfig> stateConfigs) { }

	private void CreatePlayables(List<CustomAnimationClipConfig> clipConfigs) { }

	private void CreatePlayables(List<AnimationClip> clips) { }

	[CompilerGenerated]
	public override int get_currentAnimationState() { }

	public int get_QueuedReturnState() { }

	public string GetAnimNameByIndex(int index) { }

	public float GetCurrentAnimationTime() { }

	public int GetStateIndexByAnimationName(string animationName) { }

	private void Init() { }

	private void OnDestroy() { }

	public override void Play() { }

	public override void Play(int state, bool forceInterrupt = false) { }

	public override void Play(int state, int returnState, bool forceInterrupt = false) { }

	[CompilerGenerated]
	private void set_currentAnimationState(int value) { }

	public void SetAnimations(List<CustomAnimationClipConfig> clips) { }

	public void SetAnimations(List<AnimationBakerStateConfig> clips) { }

	public void SetAnimations(List<AnimationClip> clips) { }

	public void SetAnimationSpeed(float speed) { }

	public void SetAnimationTime(float time) { }

	public void SetBlends(List<BlendInfo> blendInfos) { }

	public void SetNormalizedAnimationTime(float normalizedTime) { }

	public void SetState(string animationName) { }

	public override void SetState(int state) { }

	public void SetState(int state, bool resetTime) { }

	[IteratorStateMachine(typeof(<SwapAnimations>d__48))]
	public IEnumerator SwapAnimations(List<AnimationChange> animationChanges) { }

	public void UnswapAnimations() { }

	private void Update() { }

	public void ZeroOutMixerWeights() { }

}

