namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class WallOfTrees : ProjectileBehavior
{
	public WallOfTrees parent; //Field offset: 0x88
	public float rbeCapacity; //Field offset: 0x90
	public string expRbeCapacity; //Field offset: 0x98
	public float rbeCashMultiplier; //Field offset: 0xA0
	public string expRbeCashMultiplier; //Field offset: 0xA8
	public Projectile projectile; //Field offset: 0xB0
	public Projectile expProjectile; //Field offset: 0xB8
	public Emission emission; //Field offset: 0xC0
	public Emission expEmission; //Field offset: 0xC8
	public int animationState; //Field offset: 0xD0
	public string expAnimationState; //Field offset: 0xD8
	public bool onlyDamageLastBloon; //Field offset: 0xE0
	public string expOnlyDamageLastBloon; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 290
	}

	public WallOfTrees() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

