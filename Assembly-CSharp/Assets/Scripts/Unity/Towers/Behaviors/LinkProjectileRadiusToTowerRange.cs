namespace Assets.Scripts.Unity.Towers.Behaviors;

public class LinkProjectileRadiusToTowerRange : TowerBehavior
{
	public LinkProjectileRadiusToTowerRange parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public float projectileRadiusOffset; //Field offset: 0xB0
	public string expProjectileRadiusOffset; //Field offset: 0xB8
	public float displayRadius; //Field offset: 0xC0
	public string expDisplayRadius; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 284
	}

	public LinkProjectileRadiusToTowerRange() { }

	public virtual TowerBehaviorModel get_Def() { }

}

