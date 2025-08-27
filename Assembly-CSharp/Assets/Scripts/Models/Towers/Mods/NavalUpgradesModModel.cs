namespace Assets.Scripts.Models.Towers.Mods;

public class NavalUpgradesModModel : MutatorModModel
{
	public float amount; //Field offset: 0x30

	public NavalUpgradesModModel(string name, float amount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

