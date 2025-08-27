namespace Assets.Scripts.Models.Rounds;

public class IncomeSetModel : Model
{
	private readonly RoundThresholdMultiplier[] thresholds; //Field offset: 0x30
	private readonly float finalMultiplier; //Field offset: 0x38

	public IncomeSetModel(string name, RoundThresholdMultiplier[] thresholds, float finalMultiplier) { }

	public virtual Model Clone() { }

	public float IncomeMultiplierForRound(int round) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

