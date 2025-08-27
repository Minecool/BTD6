namespace Assets.Scripts.Models.Towers.Mods;

public class WindModModel : MutatorModModel
{
	public float chanceIncrease; //Field offset: 0x30

	public WindModModel(string name, float chanceIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

