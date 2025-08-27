namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ImfLoan", menuName = "BTD6/Behaviors/Abilities/ImfLoan")]
public class ImfLoan : AbilityBehavior
{
	public float amount; //Field offset: 0x30
	public float incomeRecoveryRate; //Field offset: 0x34
	public float lifespan; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 175
	}

	public ImfLoan() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

