namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AgeRandom : ProjectileBehavior
{
	public AgeRandom parent; //Field offset: 0x88
	public float minLifespan; //Field offset: 0x90
	public string expMinLifespan; //Field offset: 0x98
	public float maxLifespan; //Field offset: 0xA0
	public string expMaxLifespan; //Field offset: 0xA8
	public int rounds; //Field offset: 0xB0
	public string expRounds; //Field offset: 0xB8
	public bool useRoundTime; //Field offset: 0xC0
	public string expUseRoundTime; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 390
	}

	public AgeRandom() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

