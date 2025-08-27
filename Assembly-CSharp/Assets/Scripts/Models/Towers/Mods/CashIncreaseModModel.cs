namespace Assets.Scripts.Models.Towers.Mods;

public class CashIncreaseModModel : MutatorModModel
{
	public float additionalAmount; //Field offset: 0x30
	public float percentIncrease; //Field offset: 0x34

	public CashIncreaseModModel(string name, float additionalAmount, float percentIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

