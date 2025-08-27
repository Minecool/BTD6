namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "SingleEmmisionTowardsTarget", menuName = "BTD6/Behaviors/Emissions/SingleEmmisionTowardsTarget")]
public class SingleEmmisionTowardsTarget : Emission
{
	public float offset; //Field offset: 0x30

	public virtual EmissionModel Def
	{
		 get { } //Length: 156
	}

	public SingleEmmisionTowardsTarget() { }

	public virtual EmissionModel get_Def() { }

}

