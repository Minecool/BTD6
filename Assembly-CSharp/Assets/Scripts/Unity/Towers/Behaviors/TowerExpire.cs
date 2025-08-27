namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerExpire : TowerBehavior
{
	public TowerExpire parent; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public int rounds; //Field offset: 0xB0
	public string expRounds; //Field offset: 0xB8
	public bool expireOnRoundComplete; //Field offset: 0xC0
	public string expExpireOnRoundComplete; //Field offset: 0xC8
	public bool expireOnDefeatScreen; //Field offset: 0xD0
	public string expExpireOnDefeatScreen; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 179
	}

	public TowerExpire() { }

	public virtual TowerBehaviorModel get_Def() { }

}

