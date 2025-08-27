namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "PointEmission", menuName = "BTD6/Behaviors/Emissions/PointEmission")]
public class PointEmission : Emission
{
	public bool checkLineOfSight; //Field offset: 0x30

	public virtual EmissionModel Def
	{
		 get { } //Length: 156
	}

	public PointEmission() { }

	public virtual EmissionModel get_Def() { }

}

