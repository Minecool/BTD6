namespace Assets.Scripts.Models.Towers.Mods;

public class TCBOOModModel : MutatorModModel
{

	public TCBOOModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

