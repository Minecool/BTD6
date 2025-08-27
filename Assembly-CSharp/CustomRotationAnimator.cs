//Type is in global namespace

public class CustomRotationAnimator : CustomAnimationComponent
{
	private enum Axis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	[SerializeField]
	private float rotationsPerDuration; //Field offset: 0x58
	[SerializeField]
	private Axis axis; //Field offset: 0x5C
	[SerializeField]
	private bool useLocalCoordinateSustem; //Field offset: 0x60
	[SerializeField]
	private bool randomizeAngle; //Field offset: 0x61
	[SerializeField]
	private bool randomizeSpeed; //Field offset: 0x62
	[SerializeField]
	private RangeValue randomSpeedMultiplierRange; //Field offset: 0x68
	private float angleOffset; //Field offset: 0x70
	private Vector3 rotationAxis; //Field offset: 0x74

	public float AngleOffset
	{
		 get { } //Length: 6
	}

	public Vector3 RotationAxis
	{
		 get { } //Length: 19
	}

	public float RotationsPerDuration
	{
		 get { } //Length: 6
	}

	public CustomRotationAnimator() { }

	protected virtual void Awake() { }

	public float get_AngleOffset() { }

	public Vector3 get_RotationAxis() { }

	public float get_RotationsPerDuration() { }

	public void SetReverse() { }

	protected virtual void UpdateAnimation(float currentTime) { }

}

