namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(IncreaseTowerWorthOverRounds), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseTowerWorthOverRoundsModel : TowerBehaviorModel
{
	public float bracket1PercentPerRound; //Field offset: 0x30
	public float bracket2PercentPerRound; //Field offset: 0x34
	public float bracket3PercentPerRound; //Field offset: 0x38
	public int bracket2Round; //Field offset: 0x3C
	public int bracket3Round; //Field offset: 0x40

	public IncreaseTowerWorthOverRoundsModel(string name, float bracket1PercentPerRound, float bracket2PercentPerRound, float bracket3PercentPerRound, int bracket2Round, int bracket3Round) { }

	public virtual Model Clone() { }

	public float GetWorthMultiplier(int currentRound, int startedCountingAtRound) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

