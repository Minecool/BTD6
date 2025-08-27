namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DetonateEffect", menuName = "BTD6/Behaviors/Projectiles/DetonateEffect")]
public class DetonateEffect : ProjectileBehavior
{
	public string effectMutationIds; //Field offset: 0x30
	public float damagePerSecondRemaining; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public DetonateEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

