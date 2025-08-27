namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SubmergeEffect : TowerBehavior
{
	public SubmergeEffect parent; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8
	public Projectile projectile; //Field offset: 0xB0
	public Projectile expProjectile; //Field offset: 0xB8
	public float displayRadius; //Field offset: 0xC0
	public string expDisplayRadius; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 287
	}

	public SubmergeEffect() { }

	public virtual TowerBehaviorModel get_Def() { }

}

