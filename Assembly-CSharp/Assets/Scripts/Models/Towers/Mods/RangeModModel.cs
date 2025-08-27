namespace Assets.Scripts.Models.Towers.Mods;

public class RangeModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30
	public float additive; //Field offset: 0x34

	public RangeModModel(string name, float multiplier, float additive) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

