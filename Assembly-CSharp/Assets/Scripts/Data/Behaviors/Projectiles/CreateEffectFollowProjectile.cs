namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectFollowProjectile", menuName = "BTD6/Behaviors/Projectiles/CreateEffectFollowProjectile")]
public class CreateEffectFollowProjectile : ProjectileBehavior
{
	public Effect effect; //Field offset: 0x30
	public OffsetPosition offset; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 271
	}

	public CreateEffectFollowProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

