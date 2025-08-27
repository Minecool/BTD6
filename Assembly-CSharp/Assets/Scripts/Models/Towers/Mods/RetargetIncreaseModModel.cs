namespace Assets.Scripts.Models.Towers.Mods;

public class RetargetIncreaseModModel : MutatorModModel
{
	public int amount; //Field offset: 0x30

	public RetargetIncreaseModModel(string name, int amount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

