namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetGrapplable), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetGrapplableModel : TargetSupplierModel
{
	public GrappleEmissionModel grappleEmissionModel; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x40
	public int hooks; //Field offset: 0x44
	public int zomgHooksRequired; //Field offset: 0x48
	public int badHooksRequired; //Field offset: 0x4C

	public TargetGrapplableModel(string name, GrappleEmissionModel grappleEmissionModel, bool isSelectable, bool isOnSubTower, int hooks, int zomgHooksRequired, int badHooksRequired) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

