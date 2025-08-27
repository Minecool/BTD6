namespace Assets.Scripts.Unity.Display.Animation;

public class PlayableFrameBakerAnimator : MonoBehaviour
{
	[Header("Optional (supply if not on same game object)")]
	public Animator animator; //Field offset: 0x20
	private PlayableGraph playableGraph; //Field offset: 0x28
	private AnimationPlayableOutput playableOutput; //Field offset: 0x38
	private AnimationClipPlayable playableClip; //Field offset: 0x48
	public List<CustomPlayableAnimationClip> playableAnimationClips; //Field offset: 0x58
	private int currentAnimationState; //Field offset: 0x60
	private CustomPlayableAnimationClip currentAnimation; //Field offset: 0x68
	public string currentAnimationName; //Field offset: 0x70

	public PlayableFrameBakerAnimator() { }

	private void CreatePlayable(AnimationBakerStateConfig config) { }

	private void CreatePlayables(List<AnimationBakerStateConfig> stateConfigs) { }

	public int GetStateIndexByAnimationName(string animationName) { }

	private void Init() { }

	public void SetAnimations(List<AnimationBakerStateConfig> clips) { }

	public void SetAnimationTime(float time) { }

	public void SetNormalizedAnimationTime(float normalizedTime) { }

	public void SetState(string animationClipName) { }

	public bool ValidateAnimations() { }

}

