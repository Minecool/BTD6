namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RandomRangeTravelStrait : ProjectileBehavior
{
	public RandomRangeTravelStrait parent; //Field offset: 0x88
	public float minRange; //Field offset: 0x90
	public string expMinRange; //Field offset: 0x98
	public float maxRange; //Field offset: 0xA0
	public string expMaxRange; //Field offset: 0xA8
	public float speed; //Field offset: 0xB0
	public string expSpeed; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 164
	}

	public RandomRangeTravelStrait() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

