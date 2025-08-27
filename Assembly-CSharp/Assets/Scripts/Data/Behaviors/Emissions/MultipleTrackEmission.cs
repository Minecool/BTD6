namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "MultipleTrackEmission", menuName = "BTD6/Behaviors/Emissions/MultipleTrackEmission")]
public class MultipleTrackEmission : Emission
{
	public float offset; //Field offset: 0x30
	public float count; //Field offset: 0x34

	public virtual EmissionModel Def
	{
		 get { } //Length: 178
	}

	public MultipleTrackEmission() { }

	public virtual EmissionModel get_Def() { }

}

