//Type is in global namespace

public class CustomPlayableAnimatorTest : MonoBehaviour
{
	[SerializeField]
	public PlayableAnimator playableAnimator; //Field offset: 0x20
	[SerializeField]
	public List<CustomAnimationClipConfig> clipConfigs; //Field offset: 0x28

	public CustomPlayableAnimatorTest() { }

	private void Start() { }

	private void Update() { }

}

