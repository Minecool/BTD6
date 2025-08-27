namespace Assets.Scripts.Models.ContestedTerritory;

public class CtAddDamageForBloonTypeModModel : MutatorModModel
{
	private readonly string type; //Field offset: 0x30
	private readonly float extraDamage; //Field offset: 0x38

	public CtAddDamageForBloonTypeModModel(string name, string type, float extraDamage) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

