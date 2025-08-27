namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "BigSqueezeFortifiedEffect", menuName = "BTD6/Behaviors/Projectiles/BigSqueezeFortifiedEffect")]
public class BigSqueezeFortifiedEffect : ProjectileBehavior
{
	public bool randomRotation; //Field offset: 0x30
	public Effect effect; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 219
	}

	public BigSqueezeFortifiedEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

