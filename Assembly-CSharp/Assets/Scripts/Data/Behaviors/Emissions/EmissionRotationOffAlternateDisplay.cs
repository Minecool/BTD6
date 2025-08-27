namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffAlternateDisplay", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffAlternateDisplay")]
public class EmissionRotationOffAlternateDisplay : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EmissionRotationOffAlternateDisplay() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

