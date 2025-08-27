namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RandomRangeTravelStraight", menuName = "BTD6/Behaviors/Projectiles/RandomRangeTravelStraight")]
public class RandomRangeTravelStrait : ProjectileBehavior
{
	public float minRange; //Field offset: 0x30
	public float maxRange; //Field offset: 0x34
	public float speed; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public RandomRangeTravelStrait() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

