namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "FilterTargetAngleFilter", menuName = "BTD6/Behaviors/Weapons/FilterTargetAngleFilter")]
public class FilterTargetAngleFilter : WeaponBehavior
{
	public float fieldOfView; //Field offset: 0x30
	public float baseTowerRotationOffset; //Field offset: 0x34
	public bool shareFilterTargets; //Field offset: 0x38
	public float minTimeBetweenFilterTargets; //Field offset: 0x3C

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 184
	}

	public FilterTargetAngleFilter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

