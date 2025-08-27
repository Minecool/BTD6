namespace Assets.Scripts.Unity.Powers;

public class RoadSpikes : PowerBehavior
{
	public Projectile projectile; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public RoadSpikes() { }

	public virtual PowerBehaviorModel get_Def() { }

}

