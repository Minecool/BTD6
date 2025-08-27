namespace Assets.Scripts.Models.Towers.Mods;

public class AbilityCooldownPercentageModModel : MutatorModModel
{
	public float cooldownPercentageReduction; //Field offset: 0x30

	public AbilityCooldownPercentageModModel(string name, float cooldownPercentageReduction) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

