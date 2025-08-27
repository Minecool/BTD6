namespace Assets.Scripts.Models.Towers.Mods;

public class SlowModifierModModel : MutatorModModel
{
	public float durationModifier; //Field offset: 0x30
	public float slowModifier; //Field offset: 0x34
	public string mutationId; //Field offset: 0x38

	public SlowModifierModModel(string name, float durationModifier, float slowModifier, string mutationId) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

