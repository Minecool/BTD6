namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class PlayInteractableClip : InteractableObject
{
	public AnimationClip animationClip; //Field offset: 0x20
	public PlayInteractableAudio interactableAudio; //Field offset: 0x28
	[Header("Optional (drag animator in here if not on same game object)")]
	public Animator animator; //Field offset: 0x30
	[Header("Set label if you want to play a specific animation trigger on click")]
	public string triggerLabel; //Field offset: 0x38
	[Header("If you are using a trigger label, fill in the length (seconds) of the animation you are triggering")]
	public float triggerAnimationLength; //Field offset: 0x40
	private PlayableGraph playableGraph; //Field offset: 0x48
	private AnimationPlayableOutput playableOutput; //Field offset: 0x58
	private AnimationClipPlayable playableClip; //Field offset: 0x68
	[Header("If checked, clicking while animation is playing will not reset it")]
	public bool noInterrupt; //Field offset: 0x78
	public int activationsTillDestroy; //Field offset: 0x7C
	private float lastTriggered; //Field offset: 0x80
	private int activations; //Field offset: 0x84

	public double ClipTime
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public double NormalizedTime
	{
		 get { } //Length: 117
		 set { } //Length: 125
	}

	public PlayInteractableClip() { }

	public double get_ClipTime() { }

	public double get_NormalizedTime() { }

	public bool IsUsingTriggerLabel() { }

	public void OnDestroy() { }

	public virtual void OnInteract() { }

	public void set_ClipTime(double value) { }

	public void set_NormalizedTime(double value) { }

	private void Start() { }

}

