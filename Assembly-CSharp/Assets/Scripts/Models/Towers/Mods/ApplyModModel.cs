namespace Assets.Scripts.Models.Towers.Mods;

public class ApplyModModel : Model
{
	public string mod; //Field offset: 0x30
	public string target; //Field offset: 0x38

	public ApplyModModel(string name, string mod, string target) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

