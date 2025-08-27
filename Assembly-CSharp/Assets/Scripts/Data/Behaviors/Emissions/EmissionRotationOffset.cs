namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffset", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffset")]
public class EmissionRotationOffset : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public EmissionRotationOffset() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

