namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TravelCurvy : TravelStrait
{
	public float turnRate; //Field offset: 0xB0
	public string expTurnRate; //Field offset: 0xB8
	public float maxTurnAngle; //Field offset: 0xC0
	public string expMaxTurnAngle; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 270
	}

	public TravelCurvy() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

