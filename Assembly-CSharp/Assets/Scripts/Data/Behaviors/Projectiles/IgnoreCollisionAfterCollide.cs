namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "IgnoreCollisionAfterCollide", menuName = "BTD6/Behaviors/Projectiles/IgnoreCollisionAfterCollide")]
public class IgnoreCollisionAfterCollide : ProjectileBehavior
{
	public float timeAfterCollide; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public IgnoreCollisionAfterCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

