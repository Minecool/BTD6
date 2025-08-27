namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterTargetAngle : Filter
{
	public FilterTargetAngle parent; //Field offset: 0x88
	public float fieldOfView; //Field offset: 0x90
	public string expFieldOfView; //Field offset: 0x98
	public float baseTowerRotationOffset; //Field offset: 0xA0
	public string expBaseTowerRotationOffset; //Field offset: 0xA8
	public bool ignoreTowerRotation; //Field offset: 0xB0
	public string expIgnoreTowerRotation; //Field offset: 0xB8

	public virtual FilterModel Def
	{
		 get { } //Length: 157
	}

	public FilterTargetAngle() { }

	public virtual FilterModel get_Def() { }

}

