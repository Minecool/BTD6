namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CollectCreatedProjectile : TowerBehavior
{
	public CollectCreatedProjectile parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public CollectCreatedProjectile() { }

	public virtual TowerBehaviorModel get_Def() { }

}

