namespace Assets.Scripts.Models.Rounds;

public class RoundModel : Model
{
	public BloonGroupModel[] groups; //Field offset: 0x30
	private BloonEmissionModel[] emissions_; //Field offset: 0x38

	public BloonEmissionModel[] emissions
	{
		 get { } //Length: 458
	}

	public RoundModel(string name, BloonGroupModel[] groups) { }

	public virtual Model Clone() { }

	public BloonEmissionModel[] get_emissions() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

