namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "RandomTargetSpread", menuName = "BTD6/Behaviors/Emissions/RandomTargetSpread")]
public class RandomTargetSpread : Emission
{
	public float spread; //Field offset: 0x30
	public ThrowMarkerOffset[] throwMarkerOffsets; //Field offset: 0x38

	public virtual EmissionModel Def
	{
		 get { } //Length: 202
	}

	public RandomTargetSpread() { }

	public virtual EmissionModel get_Def() { }

}

