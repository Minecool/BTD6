namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetTrackOrDefaultAcidPool), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetTrackOrDefaultAcidPoolModel : TargetSupplierModel
{
	public float radius; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x3C
	public bool useTowerRange; //Field offset: 0x3D
	public bool isActive; //Field offset: 0x3E

	public TargetTrackOrDefaultAcidPoolModel(string name, float radius, bool isSelectable, bool useTowerRange, bool isOnSubTower, bool isActive) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

