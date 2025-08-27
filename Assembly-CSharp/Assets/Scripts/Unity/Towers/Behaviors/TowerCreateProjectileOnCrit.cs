namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerCreateProjectileOnCrit : TowerBehavior
{
	public TowerCreateProjectileOnCrit parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8
	public float chance; //Field offset: 0xC0
	public string expChance; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 217
	}

	public TowerCreateProjectileOnCrit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

