namespace Assets.Scripts.Models.Rounds;

public class RoundSetModel : Model
{
	public readonly RoundModel[] rounds; //Field offset: 0x30
	public readonly string linkedIncomeSet; //Field offset: 0x38

	public RoundSetModel(string name, RoundModel[] rounds, string linkedIncomeSet) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

