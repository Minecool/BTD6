namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Age", menuName = "BTD6/Behaviors/Projectiles/Age")]
public class Age : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public int rounds; //Field offset: 0x34
	public bool useRoundTime; //Field offset: 0x38
	public EndOfRoundClearBypass endOfRoundClearBypass; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 329
	}

	public Age() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

