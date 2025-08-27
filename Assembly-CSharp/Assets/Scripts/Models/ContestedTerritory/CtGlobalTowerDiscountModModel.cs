namespace Assets.Scripts.Models.ContestedTerritory;

public class CtGlobalTowerDiscountModModel : MutatorModModel
{
	private readonly String[] towerIds; //Field offset: 0x30
	private readonly float costReduction; //Field offset: 0x38
	private List<String> mutatedUpgrades; //Field offset: 0x40

	public CtGlobalTowerDiscountModModel(string name, String[] towerIds, float costReduction) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

