namespace Assets.Scripts.Models.Towers.Mods;

public class IgnoreBlockersModModel : MutatorModModel
{

	public IgnoreBlockersModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

