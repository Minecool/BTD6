namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectOnContact", menuName = "BTD6/Behaviors/Projectiles/CreateEffectOnContact")]
public class CreateEffectOnContact : ProjectileBehavior
{
	public Effect effect; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 195
	}

	public CreateEffectOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

