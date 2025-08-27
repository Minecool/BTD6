namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(PatrolPointsSetting), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PatrolPointsSettingModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public float pointSwitchDistance; //Field offset: 0x3C
	public float pointSwitchDistanceSquared; //Field offset: 0x40
	public float minimumPointDistance; //Field offset: 0x44
	public float minimumPointDistanceSquared; //Field offset: 0x48
	public float dotSpacing; //Field offset: 0x4C
	public float dotOffset; //Field offset: 0x50
	public PrefabReference display; //Field offset: 0x58
	public PrefabReference lineDisplay; //Field offset: 0x60
	[SerializeField]
	private float lineDelay; //Field offset: 0x68
	public int lineDelayFrames; //Field offset: 0x6C

	public PatrolPointsSettingModel(string name, bool isSelectable, PrefabReference display, PrefabReference lineDisplay, float lineDelay, float dotSpacing, float dotOffset, float pointSwitchDistance, float minimumPointDistance, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	public virtual string GetTargetTypeCustomInputClass() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

