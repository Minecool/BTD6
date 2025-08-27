namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "AcidPoolEmission", menuName = "BTD6/Behaviors/Emissions/AcidPoolEmission")]
public class AcidPoolEmission : EmissionBehavior
{
	public int alwaysPoolOnCount; //Field offset: 0x28

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public AcidPoolEmission() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

