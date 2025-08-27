namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffBloonDirection", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffBloonDirection")]
public class EmissionRotationOffBloonDirection : EmissionBehavior
{
	public bool useAirUnitPosition; //Field offset: 0x28
	public bool dontSetAfterEmit; //Field offset: 0x29

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public EmissionRotationOffBloonDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

