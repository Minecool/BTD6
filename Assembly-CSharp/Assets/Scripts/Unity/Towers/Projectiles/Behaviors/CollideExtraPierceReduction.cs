namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CollideExtraPierceReduction : ProjectileBehavior
{
	public CollideExtraPierceReduction parent; //Field offset: 0x88
	public string bloonTag; //Field offset: 0x90
	public string expBloonTag; //Field offset: 0x98
	public int extraAmount; //Field offset: 0xA0
	public string expExtraAmount; //Field offset: 0xA8
	public bool destroyProjectileIfPierceNotEnough; //Field offset: 0xB0
	public string expDestroyProjectileIfPierceNotEnough; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public CollideExtraPierceReduction() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

