namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RemoveDamageTypeModifier", menuName = "BTD6/Behaviors/Projectiles/RemoveDamageTypeModifier")]
public class RemoveDamageTypeModifier : ProjectileBehavior
{
	public BloonProperties bloonPropertiesToRemove; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public int layers; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 168
	}

	public RemoveDamageTypeModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

