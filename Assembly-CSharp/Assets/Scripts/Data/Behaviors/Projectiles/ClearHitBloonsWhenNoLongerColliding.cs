namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ClearHitBloonsWhenNoLongerColliding", menuName = "BTD6/Behaviors/Projectiles/ClearHitBloonsWhenNoLongerColliding")]
public class ClearHitBloonsWhenNoLongerColliding : ProjectileBehavior
{
	public float interval; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public ClearHitBloonsWhenNoLongerColliding() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

