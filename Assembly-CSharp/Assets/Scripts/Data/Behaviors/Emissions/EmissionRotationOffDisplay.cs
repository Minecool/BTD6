namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffDisplay", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffDisplay")]
public class EmissionRotationOffDisplay : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EmissionRotationOffDisplay() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

