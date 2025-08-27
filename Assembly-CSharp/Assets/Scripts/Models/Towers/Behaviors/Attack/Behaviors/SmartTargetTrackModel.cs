namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(SmartTargetTrack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SmartTargetTrackModel : TargetSupplierModel
{
	public float radius; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x3C
	public float maxOffset; //Field offset: 0x40

	public SmartTargetTrackModel(string name, float radius, bool isSelectable, bool isOnSubTower, float maxOffset) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

