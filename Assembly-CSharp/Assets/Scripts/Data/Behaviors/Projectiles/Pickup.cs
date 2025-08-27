namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Pickup", menuName = "BTD6/Behaviors/Projectiles/Pickup")]
public class Pickup : ProjectileBehavior
{
	public float collectRadius; //Field offset: 0x30
	public float delay; //Field offset: 0x34
	public bool canAttractCamo; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public Pickup() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

