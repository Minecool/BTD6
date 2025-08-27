namespace Assets.Scripts.Models.Towers.Mods;

public class AddBehaviourToBloonMutationModModel : MutatorModModel
{
	public string mutationId; //Field offset: 0x30

	public AddBehaviourToBloonMutationModModel(string name, string mutationId) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

