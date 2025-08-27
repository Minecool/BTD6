namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "ParallelEmission", menuName = "BTD6/Behaviors/Emissions/ParallelEmission")]
public class ParallelEmission : Emission
{
	public float spreadLength; //Field offset: 0x30
	public float yOffset; //Field offset: 0x34
	public float count; //Field offset: 0x38
	public bool linear; //Field offset: 0x3C

	public virtual EmissionModel Def
	{
		 get { } //Length: 222
	}

	public ParallelEmission() { }

	public virtual EmissionModel get_Def() { }

}

