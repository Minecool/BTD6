namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerCreateProjectile : TowerBehavior
{
	public TowerCreateProjectile parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8
	public float interval; //Field offset: 0xC0
	public string expInterval; //Field offset: 0xC8
	public bool useRoundTime; //Field offset: 0xD0
	public string expUseRoundTime; //Field offset: 0xD8
	public float chance; //Field offset: 0xE0
	public string expChance; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 264
	}

	public TowerCreateProjectile() { }

	public virtual TowerBehaviorModel get_Def() { }

}

