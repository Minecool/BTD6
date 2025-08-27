namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(OffsetToTrackTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OffsetToTrackTargetModel : TargetSupplierModel
{
	public float trackOffset; //Field offset: 0x38
	public AttackModel attackModel; //Field offset: 0x40
	public bool isSelectable; //Field offset: 0x48

	public OffsetToTrackTargetModel(string name, float trackOffset, AttackModel attackModel, bool isSelectable, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

