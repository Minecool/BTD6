namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(CenterElipsePattern), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CenterElipsePatternModel : TargetSupplierModel
{
	public float widthRadius; //Field offset: 0x38
	public float heightRadius; //Field offset: 0x3C
	public bool isSelectable; //Field offset: 0x40
	public bool reverse; //Field offset: 0x41
	public PrefabReference display; //Field offset: 0x48
	public int displayCount; //Field offset: 0x50
	public bool canSelectPoint; //Field offset: 0x54
	public PrefabReference pointDisplay; //Field offset: 0x58

	public CenterElipsePatternModel(string name, float widthRadius, float heightRadius, bool isSelectable, bool reverse, PrefabReference display, int displayCount, bool isOnSubTower, bool canSelectPoint, PrefabReference pointDisplay) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	public virtual string GetTargetTypeCustomInputClass() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

