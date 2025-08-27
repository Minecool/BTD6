//Type is in global namespace

public class CustomRendererToggleAnimator : MonoBehaviour
{
	public Renderer targetRenderer; //Field offset: 0x20
	public float duration; //Field offset: 0x28
	public AnimationCurve curve; //Field offset: 0x30
	public bool isPlaying; //Field offset: 0x38
	public bool loop; //Field offset: 0x39
	private float elapsed; //Field offset: 0x3C

	public CustomRendererToggleAnimator() { }

	private void Start() { }

	private void Update() { }

	private void UpdateToggle(float currentTime) { }

}

