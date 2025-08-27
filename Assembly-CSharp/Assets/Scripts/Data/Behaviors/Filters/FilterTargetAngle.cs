namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterTargetAngle", menuName = "BTD6/Behaviors/Filters/FilterTargetAngle")]
public class FilterTargetAngle : Filter
{
	public float fieldOfView; //Field offset: 0x30
	public float baseTowerRotationOffset; //Field offset: 0x34
	public bool ignoreBaseTowerRotation; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 148
	}

	public FilterTargetAngle() { }

	public virtual FilterModel get_Def() { }

}

