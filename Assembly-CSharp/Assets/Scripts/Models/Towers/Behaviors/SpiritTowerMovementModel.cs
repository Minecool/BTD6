namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SpiritTowerMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpiritTowerMovementModel : TowerBehaviorModel
{
	public float distance; //Field offset: 0x30
	public float tolerance; //Field offset: 0x34
	public float acceleration; //Field offset: 0x38
	public float accelerationPerFrame; //Field offset: 0x3C
	public float speed; //Field offset: 0x40
	public float minSpeed; //Field offset: 0x44
	public float minSpeedPerFrame; //Field offset: 0x48
	public float maxSpeed; //Field offset: 0x4C
	public float maxSpeedPerFrame; //Field offset: 0x50
	public float rotation; //Field offset: 0x54
	public float accelerateInAngle; //Field offset: 0x58
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x5C
	public int baseAttackAnimState; //Field offset: 0x60
	public int spinAttackAnimState; //Field offset: 0x64
	public int searchDelayFrames; //Field offset: 0x68
	[SerializeField]
	private float searchDelay; //Field offset: 0x6C
	public int delayUntilNoTargetRetreatFrames; //Field offset: 0x70
	[SerializeField]
	private float delayUntilNoTargetRetreat; //Field offset: 0x74
	public int delayBetweenIdleMinFrames; //Field offset: 0x78
	[SerializeField]
	private float delayBetweenIdleMin; //Field offset: 0x7C
	public int delayBetweenIdleMaxFrames; //Field offset: 0x80
	[SerializeField]
	private float delayBetweenIdleMax; //Field offset: 0x84

	public float DelayBetweenIdleMax
	{
		 get { } //Length: 9
		 set { } //Length: 27
	}

	public float DelayBetweenIdleMin
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public float DelayUntilNoTargetRetreat
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public float SearchDelay
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public SpiritTowerMovementModel(string name, float distance, float tolerance, float acceleration, float speed, float minSpeed, float maxSpeed, float rotation, float accelerateInAngle, float startDeceleratingIfAngleGreaterThan, float searchDelay, float delayUntilNoTargetRetreat, float delayBetweenIdleMin, float delayBetweenIdleMax, int baseAttackAnimState, int spinAttackAnimState) { }

	public virtual Model Clone() { }

	public float get_DelayBetweenIdleMax() { }

	public float get_DelayBetweenIdleMin() { }

	public float get_DelayUntilNoTargetRetreat() { }

	public float get_SearchDelay() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_DelayBetweenIdleMax(float value) { }

	public void set_DelayBetweenIdleMin(float value) { }

	public void set_DelayUntilNoTargetRetreat(float value) { }

	public void set_SearchDelay(float value) { }

}

