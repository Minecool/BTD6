namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "RandomArcEmission", menuName = "BTD6/Behaviors/Emissions/RandomArcEmission")]
public class RandomArcEmission : Emission
{
	public float angle; //Field offset: 0x30
	public float count; //Field offset: 0x34
	public float offset; //Field offset: 0x38
	public float randomAngle; //Field offset: 0x3C
	public float startOffset; //Field offset: 0x40

	public virtual EmissionModel Def
	{
		 get { } //Length: 254
	}

	public RandomArcEmission() { }

	public virtual EmissionModel get_Def() { }

}

