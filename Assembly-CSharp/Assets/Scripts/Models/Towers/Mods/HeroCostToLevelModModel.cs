namespace Assets.Scripts.Models.Towers.Mods;

public class HeroCostToLevelModModel : MutatorModModel
{
	public float costMultiplier; //Field offset: 0x30

	public HeroCostToLevelModModel(string name, float costMultiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

