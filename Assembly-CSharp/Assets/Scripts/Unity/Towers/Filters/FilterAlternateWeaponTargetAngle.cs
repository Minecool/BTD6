namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterAlternateWeaponTargetAngle : Filter
{
	public FilterAlternateWeaponTargetAngle parent; //Field offset: 0x88
	public float fieldOfView; //Field offset: 0x90
	public string expFieldOfView; //Field offset: 0x98
	public float baseTowerRotationOffset; //Field offset: 0xA0
	public string expBaseTowerRotationOffset; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 136
	}

	public FilterAlternateWeaponTargetAngle() { }

	public virtual FilterModel get_Def() { }

}

