namespace Assets.Scripts.Models.Towers.Mods;

public class DamageModifierForTagModModel : MutatorModModel
{
	public string bloonTag; //Field offset: 0x30
	public float multiplierAdditive; //Field offset: 0x38
	public float addative; //Field offset: 0x3C

	public DamageModifierForTagModModel(string name, string bloonTag, float multiplierAdditive, float addative) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

