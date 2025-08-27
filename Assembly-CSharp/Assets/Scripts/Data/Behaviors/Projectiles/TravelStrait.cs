namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TravelStrait", menuName = "BTD6/Behaviors/Projectiles/TravelStrait")]
public class TravelStrait : ProjectileBehavior
{
	public float range; //Field offset: 0x30
	public float speed; //Field offset: 0x34

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public TravelStrait() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

