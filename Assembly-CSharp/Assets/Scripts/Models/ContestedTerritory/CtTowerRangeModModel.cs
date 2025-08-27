namespace Assets.Scripts.Models.ContestedTerritory;

public class CtTowerRangeModModel : MutatorModModel
{
	private readonly float multiplier; //Field offset: 0x30

	public CtTowerRangeModModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

