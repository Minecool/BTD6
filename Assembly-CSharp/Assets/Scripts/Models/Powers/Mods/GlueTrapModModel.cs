namespace Assets.Scripts.Models.Powers.Mods;

public class GlueTrapModModel : MutatorModModel
{

	public GlueTrapModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

