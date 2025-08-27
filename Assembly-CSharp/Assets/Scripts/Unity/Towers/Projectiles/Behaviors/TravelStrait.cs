namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TravelStrait : ProjectileBehavior
{
	public TravelStrait parent; //Field offset: 0x88
	public float range; //Field offset: 0x90
	public string expRange; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 170
	}

	public TravelStrait() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

