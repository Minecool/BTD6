namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectFromCollisionToCollision", menuName = "BTD6/Behaviors/Projectiles/CreateEffectFromCollisionToCollision")]
public class CreateEffectFromCollisionToCollision : ProjectileBehavior
{
	public Effect effect; //Field offset: 0x30
	public float effectLength; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public CreateEffectFromCollisionToCollision() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

