namespace Assets.Scripts.Unity.Display.Animation;

[DisallowMultipleComponent]
public class MonkeyAnimationController : AnimationController
{
	[CompilerGenerated]
	private sealed class <ResetAnimatorCullMode>d__37 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MonkeyAnimationController <>4__this; //Field offset: 0x20

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
		public <ResetAnimatorCullMode>d__37(int <>1__state) { }

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

	private static List<AnimationBakerStateConfig> allStatesReusableTemp; //Field offset: 0x0
	private static List<BlendInfo> allBlendsReusableTemp; //Field offset: 0x8
	private static List<Int32> allIdleIndicesReusableTemp; //Field offset: 0x10
	public List<AnimationBakerStateConfig> animationStates; //Field offset: 0x40
	[HideInInspector]
	public List<AnimationBakerStateConfig> animationStatesByIndex; //Field offset: 0x48
	public List<AnimationBakerStateConfig> placementConfigs; //Field offset: 0x50
	public List<AnimationBakerStateConfig> attackIdleConfigs; //Field offset: 0x58
	public List<AnimationBakerVariantStateConfig> IdleVariants; //Field offset: 0x60
	private int currentAnimationState; //Field offset: 0x68
	private WeightedGroup<Int32> idleSelector; //Field offset: 0x70
	private bool attackReady; //Field offset: 0x78
	private int currentIdleAnimationIndex; //Field offset: 0x7C
	private float timeOfLastAttack; //Field offset: 0x80
	private float attackReadyIdleSustain; //Field offset: 0x84
	private int placementAnimationIndex; //Field offset: 0x88
	private bool wantsToPause; //Field offset: 0x8C
	private int attackIdleIndexValue; //Field offset: 0x90
	private InitialisableBoolean hasAttackReadyParam; //Field offset: 0x94

	public private int AttackIdleIndex
	{
		 get { } //Length: 72
		private set { } //Length: 7
	}

	private static MonkeyAnimationController() { }

	public MonkeyAnimationController() { }

	private void Awake() { }

	public void DebugLogIndices() { }

	public int get_AttackIdleIndex() { }

	public void GetAllHighQualityAnimationStates(List<AnimationBakerStateConfig> resultsList) { }

	public List<AnimationBakerStateConfig> GetAllHighQualityAnimationStates() { }

	private AnimationBakerStateConfig GetAnimationStateConfigByIndex(int index) { }

	public bool HasParameter(string paramName, Animator animator) { }

	protected virtual void OnPlayableLoop(int state) { }

	[IteratorStateMachine(typeof(<ResetAnimatorCullMode>d__37))]
	private IEnumerator ResetAnimatorCullMode() { }

	private int SelectIdleHighQuality() { }

	private int SelectIdleLowQuality() { }

	private void set_AttackIdleIndex(int value) { }

	private void SetAttackReadyParam() { }

	public virtual void SetState(int animationState, bool forceInterrupt = false) { }

	public virtual void SetTrigger(string trigger) { }

	public void SetUpHighQualityAnimator() { }

	public virtual void ToggleUnityAnimator(bool isOn) { }

	public virtual void TriggerStates(List<Int32> triggerStates) { }

	private void Update() { }

	public void WriteHighQualityAnimationIndices() { }

}

