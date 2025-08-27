namespace Assets.Scripts.Models.Towers.Mods;

public class TowerXpModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30

	public TowerXpModModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

