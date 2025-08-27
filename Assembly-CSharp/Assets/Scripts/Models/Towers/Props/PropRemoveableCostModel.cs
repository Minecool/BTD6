namespace Assets.Scripts.Models.Towers.Props;

[Implementation(typeof(PropRemoveableCost), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PropRemoveableCostModel : PropBehaviorModel
{
	public double removalCost; //Field offset: 0x30
	public string removalCostLoc; //Field offset: 0x38

	public PropRemoveableCostModel(double removalCost, string removalCostLoc) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

