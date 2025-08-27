namespace Assets.Scripts.Unity.Display.Animation;

public abstract class AnimationController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SwapAnimations>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AnimationController <>4__this; //Field offset: 0x20
		public List<AnimationChange> _animationChanges; //Field offset: 0x28

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
		public <SwapAnimations>d__23(int <>1__state) { }

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

	internal enum InitialisableBoolean
	{
		Uninitialised = 0,
		True = 1,
		False = 2,
	}

	internal enum Mode
	{
		UnityNativeAnimator = 0,
		CustomPlayableAnimator = 1,
	}

	public static readonly string NoFlattenTag; //Field offset: 0x0
	public static readonly string DeleteFromMeshFramesTag; //Field offset: 0x8
	public static readonly string UnmodifiedInFlattenTag; //Field offset: 0x10
	protected Mode mode; //Field offset: 0x20
	protected Animator animator; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsValidController>k__BackingField; //Field offset: 0x30
	[HideInInspector]
	public PlayableAnimator playableAnimator; //Field offset: 0x38

	public Mode AnimationMode
	{
		 get { } //Length: 4
	}

	public private override bool IsValidController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static AnimationController() { }

	protected AnimationController() { }

	public void FirstFrame() { }

	public Mode get_AnimationMode() { }

	[CompilerGenerated]
	public override bool get_IsValidController() { }

	public void Important() { }

	public void LastFrame() { }

	private void OnDestroy() { }

	protected abstract void OnPlayableLoop(int state) { }

	[CompilerGenerated]
	private void set_IsValidController(bool value) { }

	public override void SetSpeed(float speed) { }

	public abstract void SetState(int animationState, bool forceInterrupt = false) { }

	public abstract void SetTrigger(string trigger) { }

	[IteratorStateMachine(typeof(<SwapAnimations>d__23))]
	public override IEnumerator SwapAnimations(List<AnimationChange> _animationChanges) { }

	public override void ToggleUnityAnimator(bool isOn) { }

	public abstract void TriggerStates(List<Int32> triggerStates) { }

	public override void UnswapAnimations() { }

}

