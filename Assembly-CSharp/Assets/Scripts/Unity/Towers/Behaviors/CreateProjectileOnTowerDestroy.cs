namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateProjectileOnTowerDestroy : TowerBehavior
{
	public CreateProjectileOnTowerDestroy parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8
	public bool useTowerRotation; //Field offset: 0xC0
	public string expUseTowerRotation; //Field offset: 0xC8
	public bool setAgeZeroOnSell; //Field offset: 0xD0
	public string expSetAgeZeroOnSell; //Field offset: 0xD8
	public bool ignoreSubtowers; //Field offset: 0xE0
	public string expIgnoreSubtowers; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 259
	}

	public CreateProjectileOnTowerDestroy() { }

	public virtual TowerBehaviorModel get_Def() { }

}

