namespace Assets.Scripts.Models.ContestedTerritory;

public class CtTowerDiscountModModel : MutatorModModel
{
	public readonly String[] towerIds; //Field offset: 0x30
	public readonly float discountAmount; //Field offset: 0x38

	public CtTowerDiscountModModel(string name, String[] towerIds, float discountAmount) { }

	public virtual Model Clone() { }

}

