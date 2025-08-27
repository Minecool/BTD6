namespace Assets.Scripts.Models.Towers.Mods;

public class StrikeDownTheFalseModModel : MutatorModModel
{
	public DamageModifierForTagModel script; //Field offset: 0x30

	public StrikeDownTheFalseModModel(string name, DamageModifierForTagModel script) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

