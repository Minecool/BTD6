namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CollideOnlyWithTarget", menuName = "BTD6/Behaviors/Projectiles/CollideOnlyWithTarget")]
public class CollideOnlyWithTarget : ProjectileBehavior
{
	public bool collideWithFirstIfInvalidTarget; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public CollideOnlyWithTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

