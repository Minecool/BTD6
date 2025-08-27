namespace Assets.Scripts.Models.Towers.Mods;

public class AddAbilityToTowerModModel : MutatorModModel
{
	[ExtendedDrawer]
	public AbilityModel abilityModel; //Field offset: 0x30

	public AddAbilityToTowerModModel(string name, AbilityModel abilityModel) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

