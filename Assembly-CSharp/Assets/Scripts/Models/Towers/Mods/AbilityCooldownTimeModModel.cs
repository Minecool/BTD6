namespace Assets.Scripts.Models.Towers.Mods;

public class AbilityCooldownTimeModModel : MutatorModModel
{
	public float cooldownTimeReduction; //Field offset: 0x30

	public AbilityCooldownTimeModModel(string name, float cooldownTimeReduction) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

