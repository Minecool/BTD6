namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetEliteTargetting), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetEliteTargettingModel : TargetCamoModel
{
	public bool isSelectable; //Field offset: 0x38
	public float percentageThroughMap; //Field offset: 0x3C

	public TargetEliteTargettingModel(string name, bool isSelectable, bool isOnSubTower, float percentageThroughMap) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

