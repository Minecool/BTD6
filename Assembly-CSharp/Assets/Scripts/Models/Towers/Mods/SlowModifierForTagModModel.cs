namespace Assets.Scripts.Models.Towers.Mods;

public class SlowModifierForTagModModel : MutatorModModel
{
	public float slowModifier; //Field offset: 0x30
	public string tag; //Field offset: 0x38

	public SlowModifierForTagModModel(string name, float slowModifier, string tag) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

