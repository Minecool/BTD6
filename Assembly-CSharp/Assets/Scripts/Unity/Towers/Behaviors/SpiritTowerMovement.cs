namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SpiritTowerMovement : TowerBehavior
{
	public SpiritTowerMovement parent; //Field offset: 0x98
	public float distance; //Field offset: 0xA0
	public string expDistance; //Field offset: 0xA8
	public float tolerance; //Field offset: 0xB0
	public string expTolerance; //Field offset: 0xB8
	public float acceleration; //Field offset: 0xC0
	public string expAcceleration; //Field offset: 0xC8
	public float speed; //Field offset: 0xD0
	public string expSpeed; //Field offset: 0xD8
	public float minSpeed; //Field offset: 0xE0
	public string expMinSpeed; //Field offset: 0xE8
	public float maxSpeed; //Field offset: 0xF0
	public string expMaxSpeed; //Field offset: 0xF8
	public float rotation; //Field offset: 0x100
	public string expRotation; //Field offset: 0x108
	public float accelerateInAngle; //Field offset: 0x110
	public string expAccelerateInAngle; //Field offset: 0x118
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x120
	public string expStartDeceleratingIfAngleGreaterThan; //Field offset: 0x128
	public float searchDelay; //Field offset: 0x130
	public string expSearchDelay; //Field offset: 0x138
	public float delayUntilNoTargetRetreat; //Field offset: 0x140
	public string expDelayUntilNoTargetRetreat; //Field offset: 0x148
	public float delayBetweenIdleMin; //Field offset: 0x150
	public string expDelayBetweenIdleMin; //Field offset: 0x158
	public float delayBetweenIdleMax; //Field offset: 0x160
	public string expDelayBetweenIdleMax; //Field offset: 0x168
	public int baseAttackAnimState; //Field offset: 0x170
	public string expBaseAttackAnimState; //Field offset: 0x178
	public int spinAttackAnimState; //Field offset: 0x180
	public string expSpinAttackAnimState; //Field offset: 0x188

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 495
	}

	public SpiritTowerMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

