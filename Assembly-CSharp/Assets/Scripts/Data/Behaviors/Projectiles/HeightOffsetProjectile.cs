namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "HeightOffsetProjectile", menuName = "BTD6/Behaviors/Projectiles/HeightOffsetProjectile")]
public class HeightOffsetProjectile : ProjectileBehavior
{
	public int numSamples; //Field offset: 0x30
	public AnimCurve heightCurve; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 277
	}

	public HeightOffsetProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

