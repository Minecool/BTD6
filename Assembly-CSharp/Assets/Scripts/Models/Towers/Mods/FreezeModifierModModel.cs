namespace Assets.Scripts.Models.Towers.Mods;

public class FreezeModifierModModel : MutatorModModel
{
	public float durationModifier; //Field offset: 0x30
	public float durationAdd; //Field offset: 0x34
	public string mutationId; //Field offset: 0x38

	public FreezeModifierModModel(string name, float durationModifier, float durationAdd, string mutationId) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

