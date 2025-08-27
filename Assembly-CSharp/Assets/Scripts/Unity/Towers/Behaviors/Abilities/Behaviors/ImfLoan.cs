namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ImfLoan : AbilityBehavior
{
	public ImfLoan parent; //Field offset: 0x88
	public float amount; //Field offset: 0x90
	public string expAmount; //Field offset: 0x98
	public float incomeRecoveryRate; //Field offset: 0xA0
	public string expIncomeRecoveryRate; //Field offset: 0xA8
	public float lifespan; //Field offset: 0xB0
	public string expLifespan; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1137
	}

	public ImfLoan() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

