namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SpiritTowerMovement", menuName = "BTD6/Behaviors/Towers/SpiritTowerMovement")]
public class SpiritTowerMovement : TowerBehavior
{
	public float distance; //Field offset: 0x30
	public float tolerance; //Field offset: 0x34
	public float acceleration; //Field offset: 0x38
	public float speed; //Field offset: 0x3C
	public float minSpeed; //Field offset: 0x40
	public float maxSpeed; //Field offset: 0x44
	public float rotation; //Field offset: 0x48
	public float accelerateInAngle; //Field offset: 0x4C
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x50
	public float searchDelay; //Field offset: 0x54
	public float delayUntilNoTargetRetreat; //Field offset: 0x58
	public float delayBetweenIdleMin; //Field offset: 0x5C
	public float delayBetweenIdleMax; //Field offset: 0x60
	public int baseAttackAnimState; //Field offset: 0x64
	public int spinAttackAnimState; //Field offset: 0x68

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 453
	}

	public SpiritTowerMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

