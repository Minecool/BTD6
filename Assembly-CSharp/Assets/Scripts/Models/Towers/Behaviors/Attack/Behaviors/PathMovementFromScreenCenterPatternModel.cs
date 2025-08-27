namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(PathMovementFromScreenCenterPattern), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PathMovementFromScreenCenterPatternModel : TargetSupplierModel
{
	public float radius; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x3C

	public PathMovementFromScreenCenterPatternModel(string name, float radius, bool isSelectable, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

