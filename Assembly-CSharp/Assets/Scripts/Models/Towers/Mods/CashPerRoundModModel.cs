namespace Assets.Scripts.Models.Towers.Mods;

public class CashPerRoundModModel : MutatorModModel
{
	public float additionalMoney; //Field offset: 0x30

	public CashPerRoundModModel(string name, float additionalMoney) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

