namespace Assets.Scripts.Unity.Display.Animation;

public class PropAnimationController : AnimationController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string state; //Field offset: 0x10
		public Func<AnimatorControllerParameter, Boolean> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <SetTrigger>b__0(AnimatorControllerParameter x) { }

		internal bool <SetTrigger>b__1(AnimatorControllerParameter x) { }

	}

	[CompilerGenerated]
	private sealed class <SwapAnimations>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <SwapAnimations>d__7(int <>1__state) { }

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

	internal class PropAnimationControllerModel
	{
		public List<CustomRotationAnimator> customRotationAnimators; //Field offset: 0x10
		public List<Animator> childAnimators; //Field offset: 0x18
		public PlayableAnimatorSimple playableAnimatorSimple; //Field offset: 0x20

		private bool HasPlayableAnimatorSimple
		{
			private get { } //Length: 176
		}

		public bool IsValidController
		{
			 get { } //Length: 254
		}

		public PropAnimationControllerModel() { }

		private bool get_HasPlayableAnimatorSimple() { }

		public bool get_IsValidController() { }

	}

	private List<CustomRotationAnimator> customRotationAnimators; //Field offset: 0x40
	private List<Animator> childAnimators; //Field offset: 0x48
	private PlayableAnimatorSimple playableAnimatorSimple; //Field offset: 0x50

	public PropAnimationController() { }

	public void Awake() { }

	public PropAnimationControllerModel Def() { }

	protected virtual void OnPlayableLoop(int state) { }

	public virtual void SetSpeed(float speed) { }

	public virtual void SetState(int animationState, bool forceInterrupt = false) { }

	public virtual void SetTrigger(string state) { }

	[IteratorStateMachine(typeof(<SwapAnimations>d__7))]
	public virtual IEnumerator SwapAnimations(List<AnimationChange> _animationChanges) { }

	public virtual void ToggleUnityAnimator(bool isOn) { }

	public virtual void TriggerStates(List<Int32> triggerStates) { }

	public virtual void UnswapAnimations() { }

}

