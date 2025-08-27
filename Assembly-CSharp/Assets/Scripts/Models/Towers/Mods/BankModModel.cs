namespace Assets.Scripts.Models.Towers.Mods;

public class BankModModel : MutatorModModel
{
	public float additionalCapacity; //Field offset: 0x30

	public BankModModel(string name, float additionalCapacity) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

