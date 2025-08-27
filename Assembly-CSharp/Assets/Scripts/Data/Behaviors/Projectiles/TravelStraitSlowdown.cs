namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TravelStraightSlowdown", menuName = "BTD6/Behaviors/Projectiles/TravelStraightSlowdown")]
public class TravelStraitSlowdown : TravelStrait
{
	public float slowdownSpeed; //Field offset: 0x38
	public float minSpeed; //Field offset: 0x3C
	public bool canReducePierce; //Field offset: 0x40
	public int startingPierce; //Field offset: 0x44
	public int endPierce; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public TravelStraitSlowdown() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

