namespace Assets.Scripts.Unity.Towers.Behaviors;

public class OverrideCamoDetection : TowerBehavior
{
	public OverrideCamoDetection parent; //Field offset: 0x98
	public bool detectCamo; //Field offset: 0xA0
	public string expDetectCamo; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public OverrideCamoDetection() { }

	public virtual TowerBehaviorModel get_Def() { }

}

