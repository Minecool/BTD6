namespace Assets.Scripts.Models.Towers.Mods;

public class CashModModel : MutatorModModel
{
	public float percentBonus; //Field offset: 0x30
	public float bonusMultiplierBuff; //Field offset: 0x34

	public CashModModel(string name, float percentBonus, float bonusMultiplierBuff) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

