namespace Assets.Scripts.Models;

public class ModModel : Model
{
	[SerializeReference]
	public MutatorModModel[] mutatorMods; //Field offset: 0x30

	public ModModel(string name, MutatorModModel[] mutatorMods = null) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

