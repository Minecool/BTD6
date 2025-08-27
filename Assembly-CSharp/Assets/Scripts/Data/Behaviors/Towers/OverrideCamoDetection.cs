namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "OverrideCamoDetection", menuName = "BTD6/Behaviors/Towers/OverrideCamoDetection")]
public class OverrideCamoDetection : TowerBehavior
{
	public bool detectCamo; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public OverrideCamoDetection() { }

	public virtual TowerBehaviorModel get_Def() { }

}

