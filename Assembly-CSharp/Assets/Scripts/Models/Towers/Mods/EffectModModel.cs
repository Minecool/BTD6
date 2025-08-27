namespace Assets.Scripts.Models.Towers.Mods;

public class EffectModModel : MutatorModModel
{
	public float scaleReverseToBaseValueMultiplier; //Field offset: 0x30
	public float baseValueAdditive; //Field offset: 0x34
	public float baseValueMultiplier; //Field offset: 0x38

	public EffectModModel(string name, float scaleReverseToBaseValueMultiplier, float baseValueAdditive, float baseValueMultiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

