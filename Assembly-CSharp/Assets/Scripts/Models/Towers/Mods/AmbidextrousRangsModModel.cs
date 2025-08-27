namespace Assets.Scripts.Models.Towers.Mods;

public class AmbidextrousRangsModModel : MutatorModModel
{

	public AmbidextrousRangsModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

