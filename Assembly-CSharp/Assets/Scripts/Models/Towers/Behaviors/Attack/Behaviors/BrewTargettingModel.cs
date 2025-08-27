namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(BrewTargetting), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BrewTargettingModel : TargetSupplierModel
{
	public String[] towerIgnoreList; //Field offset: 0x38
	public String[] ignoreMutationsByOrder; //Field offset: 0x40
	public bool isSelectable; //Field offset: 0x48

	public BrewTargettingModel(string name, String[] towerIgnoreList, String[] ignoreMutationsByOrder, bool isSelectable, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

