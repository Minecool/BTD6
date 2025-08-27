namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class CreateEffectWhileAttacking : AttackBehavior
{
	public CreateEffectWhileAttacking parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public Effect exitEffect; //Field offset: 0xA0
	public Effect expExitEffect; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 234
	}

	public CreateEffectWhileAttacking() { }

	public virtual AttackBehaviorModel get_Def() { }

}

