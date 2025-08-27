namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ProjectileSetAnimationOnContact : ProjectileBehavior
{
	public ProjectileSetAnimationOnContact parent; //Field offset: 0x88
	public int onContactAnimationId; //Field offset: 0x90
	public string expOnContactAnimationId; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public ProjectileSetAnimationOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

