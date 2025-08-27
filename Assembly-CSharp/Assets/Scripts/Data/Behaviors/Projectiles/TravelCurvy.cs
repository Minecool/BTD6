namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TravelCurvy", menuName = "BTD6/Behaviors/Projectiles/TravelCurvy")]
public class TravelCurvy : TravelStrait
{
	public float turnRate; //Field offset: 0x38
	public float maxTurnAngle; //Field offset: 0x3C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 202
	}

	public TravelCurvy() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

