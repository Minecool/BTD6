namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionAtClosestPathSegment", menuName = "BTD6/Behaviors/Emissions/EmissionAtClosestPathSegment")]
public class EmissionAtClosestPathSegment : Emission
{
	public int count; //Field offset: 0x30
	public float spacing; //Field offset: 0x34

	public virtual EmissionModel Def
	{
		 get { } //Length: 174
	}

	public EmissionAtClosestPathSegment() { }

	public virtual EmissionModel get_Def() { }

}

