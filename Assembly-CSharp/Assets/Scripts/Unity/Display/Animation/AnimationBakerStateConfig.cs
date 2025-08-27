namespace Assets.Scripts.Unity.Display.Animation;

public class AnimationBakerStateConfig
{
	public int priority; //Field offset: 0x10
	public InterruptBehaviour interruptibleBehaviour; //Field offset: 0x14
	public bool forceSingleFrameAdvance; //Field offset: 0x18
	public bool isUpgradeAnimation; //Field offset: 0x19
	public AnimationClip animationClip; //Field offset: 0x20
	public UnityEvent eventTrigger; //Field offset: 0x28
	[HideInInspector]
	public bool looping; //Field offset: 0x30
	[Header("Don't edit values below this point")]
	public List<Single> importantFrames; //Field offset: 0x38
	public List<Single> firstFrameReturns; //Field offset: 0x40
	public List<Single> lastFrameReturns; //Field offset: 0x48
	public int animationIndex; //Field offset: 0x50

	public AnimationBakerStateConfig() { }

}

