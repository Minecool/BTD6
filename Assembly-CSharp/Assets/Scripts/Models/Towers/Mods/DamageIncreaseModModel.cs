namespace Assets.Scripts.Models.Towers.Mods;

public class DamageIncreaseModModel : MutatorModModel
{
	public float amount; //Field offset: 0x30
	public string optionalDamageScriptIds; //Field offset: 0x38

	public DamageIncreaseModModel(string name, float amount, string optionalDamageScriptIds) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

