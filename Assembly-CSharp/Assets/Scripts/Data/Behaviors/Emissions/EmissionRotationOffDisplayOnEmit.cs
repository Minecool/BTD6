namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffDisplayOnEmit", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffDisplayOnEmit")]
public class EmissionRotationOffDisplayOnEmit : EmissionBehavior
{
	public int offsetAngle; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EmissionRotationOffDisplayOnEmit() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

