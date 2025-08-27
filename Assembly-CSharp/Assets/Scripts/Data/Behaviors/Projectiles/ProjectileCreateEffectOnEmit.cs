namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ProjectileCreateEffectOnEmit", menuName = "BTD6/Behaviors/Projectiles/ProjectileCreateEffectOnEmit")]
public class ProjectileCreateEffectOnEmit : ProjectileBehavior
{
	public Effect effect; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 195
	}

	public ProjectileCreateEffectOnEmit() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

