namespace Assets.Scripts.Models.Rounds;

public class HintMessageModel : Model
{
	public string hint; //Field offset: 0x30

	public HintMessageModel(string name, string hint) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

