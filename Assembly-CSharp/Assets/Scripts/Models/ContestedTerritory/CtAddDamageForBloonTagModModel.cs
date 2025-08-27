namespace Assets.Scripts.Models.ContestedTerritory;

public class CtAddDamageForBloonTagModModel : MutatorModModel
{
	private readonly string tag; //Field offset: 0x30
	private readonly float extraDamage; //Field offset: 0x38

	public CtAddDamageForBloonTagModModel(string name, string tag, float extraDamage) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

