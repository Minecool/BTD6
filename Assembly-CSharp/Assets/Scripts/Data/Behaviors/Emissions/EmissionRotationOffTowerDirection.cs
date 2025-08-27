namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffTowerDirection", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffTowerDirection")]
public class EmissionRotationOffTowerDirection : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EmissionRotationOffTowerDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

