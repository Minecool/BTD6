namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(CirclePattern), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CirclePatternModel : TargetSupplierModel
{
	public float radius; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x3C
	public bool reverse; //Field offset: 0x3D
	public PrefabReference display; //Field offset: 0x40
	public int displayCount; //Field offset: 0x48

	public CirclePatternModel(string name, float radius, bool isSelectable, bool reverse, PrefabReference display, int displayCount, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

