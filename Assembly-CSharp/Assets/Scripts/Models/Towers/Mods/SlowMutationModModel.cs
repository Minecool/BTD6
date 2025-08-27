namespace Assets.Scripts.Models.Towers.Mods;

public class SlowMutationModModel : MutatorModModel
{
	public string mutationId; //Field offset: 0x30

	public SlowMutationModModel(string name, string mutationId) { }

	public virtual Model Clone() { }

}

