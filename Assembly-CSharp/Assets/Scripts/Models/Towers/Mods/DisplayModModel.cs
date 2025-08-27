namespace Assets.Scripts.Models.Towers.Mods;

public class DisplayModModel : MutatorModModel
{
	public float scaleReverseToBaseValueMultiplier; //Field offset: 0x30
	public float baseValueAdditive; //Field offset: 0x34
	public float baseValueMultiplier; //Field offset: 0x38

	public DisplayModModel(string name, float scaleReverseToBaseValueMultiplier, float baseValueAdditive, float baseValueMultiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

