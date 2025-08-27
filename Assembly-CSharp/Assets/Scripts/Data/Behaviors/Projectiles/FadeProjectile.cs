namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "FadeProjectile", menuName = "BTD6/Behaviors/Projectiles/FadeProjectile")]
public class FadeProjectile : ProjectileBehavior
{
	public float startFadingAt; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public FadeProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

