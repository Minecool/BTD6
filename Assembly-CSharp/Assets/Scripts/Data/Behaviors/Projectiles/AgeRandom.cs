namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AgeRandom", menuName = "BTD6/Behaviors/Projectiles/AgeRandom")]
public class AgeRandom : ProjectileBehavior
{
	public float minLifespan; //Field offset: 0x30
	public float maxLifespan; //Field offset: 0x34
	public int rounds; //Field offset: 0x38
	public bool useRoundTime; //Field offset: 0x3C
	public EndOfRoundClearBypass endOfRoundClearBypass; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 350
	}

	public AgeRandom() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

