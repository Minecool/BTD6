//Type is in global namespace

[RequireComponent(typeof(Animator))]
public class PlayablesTest : MonoBehaviour
{
	private const bool RANDOMIZE_START = True; //Field offset: 0x0
	public List<AnimationClip> clips; //Field offset: 0x20
	private Animator animator; //Field offset: 0x28
	private PlayableGraph playableGraph; //Field offset: 0x30
	private AnimationPlayableOutput playableOutput; //Field offset: 0x40
	private List<PlayableAnimationClipInfo> clipInfos; //Field offset: 0x50
	private AnimationMixerPlayable mixerPlayable; //Field offset: 0x58
	private int clipIndex; //Field offset: 0x68
	public float weight; //Field offset: 0x6C

	public PlayablesTest() { }

	public void FirstFrame() { }

	public void Important() { }

	public void LastFrame() { }

	private void OnDisable() { }

	private void Start() { }

	private void TestPlayableSystem() { }

	private void Update() { }

}

