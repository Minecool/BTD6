namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DestroyWhenHitImmune", menuName = "BTD6/Behaviors/Projectiles/DestroyWhenHitImmune")]
public class DestroyWhenHitImmune : ProjectileBehavior
{
	public bool getsDestroyed; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public DestroyWhenHitImmune() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

