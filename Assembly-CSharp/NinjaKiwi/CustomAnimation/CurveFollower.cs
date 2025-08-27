namespace NinjaKiwi.CustomAnimation;

public class CurveFollower : MonoBehaviour
{
	private class LineSegmentInfo
	{
		public float length; //Field offset: 0x10

		public LineSegmentInfo() { }

	}

	internal enum OnCompleteBehaviour
	{
		Stop = 0,
		Loop = 1,
		PingPong = 2,
	}

	public CurvedPath path; //Field offset: 0x20
	public int granularity; //Field offset: 0x28
	public float duration; //Field offset: 0x2C
	public OnCompleteBehaviour onComplete; //Field offset: 0x30
	public bool rotationFollowsCurve; //Field offset: 0x34
	public bool rotationPingPong; //Field offset: 0x35
	public bool playOnActivate; //Field offset: 0x36
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; //Field offset: 0x37
	public bool useEaseCurve; //Field offset: 0x38
	public AnimationCurve ease; //Field offset: 0x40
	public float easeMin; //Field offset: 0x48
	public float easeMax; //Field offset: 0x4C
	public bool unscaledTime; //Field offset: 0x50
	private List<PathSample> samples; //Field offset: 0x58
	private List<LineSegmentInfo> segments; //Field offset: 0x60
	private float totalLength; //Field offset: 0x68
	private float speed; //Field offset: 0x6C
	private Quaternion initialRotation; //Field offset: 0x70
	private int currentSampleIndex; //Field offset: 0x80
	private float progressToNextSample; //Field offset: 0x84
	private float totalProgressDistance; //Field offset: 0x88
	private float direction; //Field offset: 0x8C
	public bool paused; //Field offset: 0x90
	private float startTime; //Field offset: 0x94
	public Action OnLoop; //Field offset: 0x98
	private bool isInitialised; //Field offset: 0xA0

	public private bool IsPlaying
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public float Progress
	{
		 get { } //Length: 175
	}

	public CurveFollower() { }

	[CompilerGenerated]
	public bool get_IsPlaying() { }

	public float get_Progress() { }

	public void Init() { }

	public void Play() { }

	[CompilerGenerated]
	private void set_IsPlaying(bool value) { }

	private void SnapToStartOfCurve() { }

	private void Start() { }

	private void Update() { }

}

