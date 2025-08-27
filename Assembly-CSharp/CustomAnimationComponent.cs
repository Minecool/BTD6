//Type is in global namespace

public abstract class CustomAnimationComponent : MonoBehaviour
{
	[SerializeField]
	protected GameObject target; //Field offset: 0x20
	[SerializeField]
	protected float duration; //Field offset: 0x28
	[SerializeField]
	protected AnimationCurve curve; //Field offset: 0x30
	[SerializeField]
	protected bool isPlaying; //Field offset: 0x38
	[SerializeField]
	protected bool loop; //Field offset: 0x39
	[SerializeField]
	protected bool disableOnEnd; //Field offset: 0x3A
	[SerializeField]
	protected bool stopPlayingOnEnd; //Field offset: 0x3B
	[SerializeField]
	protected bool resetOnEnable; //Field offset: 0x3C
	[SerializeField]
	protected bool updateAnimOnReset; //Field offset: 0x3D
	[SerializeField]
	protected float speedMultiplier; //Field offset: 0x40
	[SerializeField]
	protected bool useUnscaledTime; //Field offset: 0x44
	protected Transform targetTransform; //Field offset: 0x48
	private float elapsed; //Field offset: 0x50

	public AnimationCurve Curve
	{
		 get { } //Length: 5
	}

	public float Duration
	{
		 get { } //Length: 6
	}

	public float SpeedMultiplier
	{
		 get { } //Length: 6
	}

	protected CustomAnimationComponent() { }

	protected override void Awake() { }

	private bool DisableIfInvalid() { }

	public AnimationCurve get_Curve() { }

	public float get_Duration() { }

	public float get_SpeedMultiplier() { }

	protected override void OnEnable() { }

	protected override void Reset() { }

	public void Trigger() { }

	private void Update() { }

	protected abstract void UpdateAnimation(float currentTime) { }

}

