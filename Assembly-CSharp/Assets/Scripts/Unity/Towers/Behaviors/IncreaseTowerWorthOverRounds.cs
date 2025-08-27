namespace Assets.Scripts.Unity.Towers.Behaviors;

public class IncreaseTowerWorthOverRounds : TowerBehavior
{
	public IncreaseTowerWorthOverRounds parent; //Field offset: 0x98
	public float bracket1PercentPerRound; //Field offset: 0xA0
	public string expBracket1PercentPerRound; //Field offset: 0xA8
	public float bracket2PercentPerRound; //Field offset: 0xB0
	public string expBracket2PercentPerRound; //Field offset: 0xB8
	public float bracket3PercentPerRound; //Field offset: 0xC0
	public string expBracket3PercentPerRound; //Field offset: 0xC8
	public int bracket2Round; //Field offset: 0xD0
	public string expBracket2Round; //Field offset: 0xD8
	public int bracket3Round; //Field offset: 0xE0
	public string expBracket3Round; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 219
	}

	public IncreaseTowerWorthOverRounds() { }

	public virtual TowerBehaviorModel get_Def() { }

}

