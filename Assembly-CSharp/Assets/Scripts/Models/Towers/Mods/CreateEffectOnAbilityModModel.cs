namespace Assets.Scripts.Models.Towers.Mods;

public class CreateEffectOnAbilityModModel : MutatorModModel
{
	public float additionalLifespan; //Field offset: 0x30

	public CreateEffectOnAbilityModModel(string name, float additionalLifespan) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

