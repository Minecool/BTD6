namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(FigureEightPattern), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FigureEightPatternModel : TargetSupplierModel
{
	public float radius; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x3C
	public bool rotated; //Field offset: 0x3D
	public PrefabReference display; //Field offset: 0x40
	public int displayCount; //Field offset: 0x48
	public bool useTowerPosition; //Field offset: 0x4C

	public FigureEightPatternModel(string name, float radius, bool rotated, bool isSelectable, PrefabReference display, int displayCount, bool isOnSubTower, bool useTowerPosition) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

