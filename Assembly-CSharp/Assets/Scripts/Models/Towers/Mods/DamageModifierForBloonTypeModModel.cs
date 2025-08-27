namespace Assets.Scripts.Models.Towers.Mods;

public class DamageModifierForBloonTypeModModel : MutatorModModel
{
	public float percentMultiplierOverride; //Field offset: 0x30
	public float percentBonus; //Field offset: 0x34
	public float additiveBonus; //Field offset: 0x38
	public string withTag; //Field offset: 0x40

	public DamageModifierForBloonTypeModModel(string name, float percentBonus, float additiveBonus, string withTag, float percentMultiplierOverride) { }

	public virtual Model Clone() { }

	private void ModDamageModel(DamageModifierForBloonTypeModel behavior) { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

