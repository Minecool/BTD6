namespace Assets.Scripts.Unity.Display.Animation;

public class CustomMeshFrameAnimator : MonoBehaviour
{
	public float fps; //Field offset: 0x20
	public List<Mesh> frames; //Field offset: 0x28
	public int currentFrame; //Field offset: 0x30
	private float elapsed; //Field offset: 0x34
	private float frameDuration; //Field offset: 0x38
	private MeshFilter meshFilter; //Field offset: 0x40
	public bool isPlaying; //Field offset: 0x48
	public bool loop; //Field offset: 0x49
	public bool randomizeFrames; //Field offset: 0x4A
	public bool randomStartFrame; //Field offset: 0x4B
	public bool resetOnEnable; //Field offset: 0x4C
	public EndAnimBehaviour endLoopBehaviour; //Field offset: 0x50

	public CustomMeshFrameAnimator() { }

	private void Awake() { }

	public void GotoAndPlay(int frame) { }

	public void GotoAndStop(int frame) { }

	private void InitFrames() { }

	public void OnEnable() { }

	public void Play() { }

	private void RecalculateFrameDuration() { }

	protected override void Reset() { }

	public void Stop() { }

	private void Update() { }

}

