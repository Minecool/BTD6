namespace Assets.Scripts.Models.ContestedTerritory;

public class CtConditionalTowerDiscountModModel : MutatorModModel
{
	public readonly Func<TowerModel, Boolean> condition; //Field offset: 0x30

	public CtConditionalTowerDiscountModModel(string name, Func<TowerModel, Boolean> condition) { }

	public virtual Model Clone() { }

}

