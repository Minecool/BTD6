namespace Assets.Scripts.Unity.Display.Animation;

public class CustomSpriteFrameAnimator : MonoBehaviour
{
	public float fps; //Field offset: 0x20
	public List<Sprite> frames; //Field offset: 0x28
	public List<FrameOverrideData> frameOverrides; //Field offset: 0x30
	public int currentFrame; //Field offset: 0x38
	private float elapsed; //Field offset: 0x3C
	private List<FrameOverrideData> fullFrameOverride; //Field offset: 0x40
	private float frameDuration; //Field offset: 0x48
	public SpriteRenderer spriteRenderer; //Field offset: 0x50
	public bool isPlaying; //Field offset: 0x58
	public bool loop; //Field offset: 0x59
	public bool randomizeFrames; //Field offset: 0x5A
	public bool randomStartFrame; //Field offset: 0x5B
	public bool resetOnEnable; //Field offset: 0x5C
	public EndLoopBehaviour endLoopBehaviour; //Field offset: 0x60

	public CustomSpriteFrameAnimator() { }

	private void Awake() { }

	public void GotoAndPlay(int frame) { }

	public void GotoAndStop(int frame) { }

	private void InitFrames() { }

	protected override void OnEnable() { }

	public void Play() { }

	private void RecalculateFrameDuration() { }

	protected override void Reset() { }

	public void Stop() { }

	private void Update() { }

}

