namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ProjectileSetAnimationOnContact", menuName = "BTD6/Behaviors/Projectiles/ProjectileSetAnimationOnContact")]
public class ProjectileSetAnimationOnContact : ProjectileBehavior
{
	public int onContactAnimationId; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public ProjectileSetAnimationOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

