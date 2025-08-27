namespace Assets.Scripts.Models.Towers.Mods;

public class GorgonStormModModel : MutatorModModel
{
	public SlowModel slowModel; //Field offset: 0x30
	public SlowModifierForTagModel moabModifierModel; //Field offset: 0x38

	public GorgonStormModModel(string name, SlowModel slowModel, SlowModifierForTagModel moabModifierModel) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

