namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateAttackSwitch", menuName = "BTD6/Behaviors/Abilities/ActivateAttackSwitch")]
public class ActivateAttackSwitch : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public Attack firstAttack; //Field offset: 0x38
	public Attack secondAttack; //Field offset: 0x40
	public bool processOnActivate; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 376
	}

	public ActivateAttackSwitch() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

