namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Age : ProjectileBehavior
{
	public Age parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public int rounds; //Field offset: 0xA0
	public string expRounds; //Field offset: 0xA8
	public bool useRoundTime; //Field offset: 0xB0
	public string expUseRoundTime; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 394
	}

	public Age() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

