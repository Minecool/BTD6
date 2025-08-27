namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Accelerate", menuName = "BTD6/Behaviors/Projectiles/Accelerate")]
public class Accelerate : ProjectileBehavior
{
	public float acceleration; //Field offset: 0x30
	public float maxSpeed; //Field offset: 0x34
	public float turnRateChange; //Field offset: 0x38
	public float maxTurnRate; //Field offset: 0x3C
	public bool decelerate; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public Accelerate() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

