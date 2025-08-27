namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "AlternatingArcEmission", menuName = "BTD6/Behaviors/Emissions/AlternatingArcEmission")]
public class AlternatingArcEmission : Emission
{
	public bool useParentRotation; //Field offset: 0x30
	public float angle; //Field offset: 0x34
	public float count; //Field offset: 0x38

	public virtual EmissionModel Def
	{
		 get { } //Length: 200
	}

	public AlternatingArcEmission() { }

	public virtual EmissionModel get_Def() { }

}

