namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "ArcEmission", menuName = "BTD6/Behaviors/Emissions/ArcEmission")]
public class ArcEmission : Emission
{
	public float angle; //Field offset: 0x30
	public float offset; //Field offset: 0x34
	public float count; //Field offset: 0x38
	public bool useProjectileRotation; //Field offset: 0x3C
	public bool useAirUnitRotation; //Field offset: 0x3D

	public virtual EmissionModel Def
	{
		 get { } //Length: 243
	}

	public ArcEmission() { }

	public virtual EmissionModel get_Def() { }

}

