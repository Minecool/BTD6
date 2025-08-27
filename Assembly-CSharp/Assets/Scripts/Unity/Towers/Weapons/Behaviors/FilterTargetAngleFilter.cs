namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class FilterTargetAngleFilter : WeaponBehavior
{
	public FilterTargetAngleFilter parent; //Field offset: 0x90
	public float fieldOfView; //Field offset: 0x98
	public string expFieldOfView; //Field offset: 0xA0
	public float baseTowerRotationOffset; //Field offset: 0xA8
	public string expBaseTowerRotationOffset; //Field offset: 0xB0
	public bool shareFilterTargets; //Field offset: 0xB8
	public string expShareFilterTargets; //Field offset: 0xC0
	public float minTimeBetweenFilterTargets; //Field offset: 0xC8
	public string expMinTimeBetweenFilterTargets; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 196
	}

	public FilterTargetAngleFilter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

