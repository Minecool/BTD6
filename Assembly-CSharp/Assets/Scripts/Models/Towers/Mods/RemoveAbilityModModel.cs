namespace Assets.Scripts.Models.Towers.Mods;

public class RemoveAbilityModModel : MutatorModModel
{

	public RemoveAbilityModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

