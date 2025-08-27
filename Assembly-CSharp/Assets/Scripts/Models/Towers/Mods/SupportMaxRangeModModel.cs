namespace Assets.Scripts.Models.Towers.Mods;

public class SupportMaxRangeModModel : MutatorModModel
{

	public SupportMaxRangeModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

