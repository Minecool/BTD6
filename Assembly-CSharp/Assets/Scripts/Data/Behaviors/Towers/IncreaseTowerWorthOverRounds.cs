namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "IncreaseTowerWorthOverRounds", menuName = "BTD6/Behaviors/Towers/IncreaseTowerWorthOverRounds")]
public class IncreaseTowerWorthOverRounds : TowerBehavior
{
	public float bracket1PercentPerRound; //Field offset: 0x30
	public float bracket2PercentPerRound; //Field offset: 0x34
	public float bracket3PercentPerRound; //Field offset: 0x38
	public int bracket2Round; //Field offset: 0x3C
	public int bracket3Round; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public IncreaseTowerWorthOverRounds() { }

	public virtual TowerBehaviorModel get_Def() { }

}

