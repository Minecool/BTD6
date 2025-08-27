namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionArcRotationOffTowerDirection", menuName = "BTD6/Behaviors/Emissions/EmissionArcRotationOffTowerDirection")]
public class EmissionArcRotationOffTowerDirection : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EmissionArcRotationOffTowerDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

