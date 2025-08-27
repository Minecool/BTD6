namespace Assets.Scripts.Models.Towers.Mods;

public class AmbushTechModModel : MutatorModModel
{

	public AmbushTechModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

