namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterAlternateWeaponTargetAngle", menuName = "BTD6/Behaviors/Filters/FilterAlternateWeaponTargetAngle")]
public class FilterAlternateWeaponTargetAngle : Filter
{
	public float fieldOfView; //Field offset: 0x30
	public float baseTowerRotationOffset; //Field offset: 0x34

	public virtual FilterModel Def
	{
		 get { } //Length: 130
	}

	public FilterAlternateWeaponTargetAngle() { }

	public virtual FilterModel get_Def() { }

}

