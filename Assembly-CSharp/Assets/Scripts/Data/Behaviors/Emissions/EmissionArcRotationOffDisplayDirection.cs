namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionArcRotationOffDisplayDirection", menuName = "BTD6/Behaviors/Emissions/EmissionArcRotationOffDisplayDirection")]
public class EmissionArcRotationOffDisplayDirection : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EmissionArcRotationOffDisplayDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

