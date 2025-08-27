namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CashBoost", menuName = "BTD6/Behaviors/Abilities/CashBoost")]
public class ExpireTowerAfterAbility : AbilityBehavior
{
	public float time; //Field offset: 0x30
	public int rounds; //Field offset: 0x34
	public bool useRoundTime; //Field offset: 0x38
	public Effect effect; //Field offset: 0x40
	public Sound sound; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 255
	}

	public ExpireTowerAfterAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

