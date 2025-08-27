namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(FilterTargetAngleFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterTargetAngleFilterModel : WeaponBehaviorModel
{
	public float fieldOfView; //Field offset: 0x30
	public float baseTowerRotationOffset; //Field offset: 0x34
	public bool shareFilterTargets; //Field offset: 0x38
	public int minTimeBetweenFilterTargetsFrames; //Field offset: 0x3C

	public FilterTargetAngleFilterModel(string name, float fieldOfView, float baseTowerRotationOffset, bool shareFilterTargets, int minTimeBetweenFilterTargetsFrames) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

