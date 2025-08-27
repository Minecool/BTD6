namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "CreateEffectWhileAttacking", menuName = "BTD6/Behaviors/Attacks/CreateEffectWhileAttacking")]
public class CreateEffectWhileAttacking : AttackBehavior
{
	public Effect effect; //Field offset: 0x30
	public Effect exitEffect; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 249
	}

	public CreateEffectWhileAttacking() { }

	public virtual AttackBehaviorModel get_Def() { }

}

