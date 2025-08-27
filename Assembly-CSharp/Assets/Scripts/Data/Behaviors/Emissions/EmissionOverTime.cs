namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionOverTime", menuName = "BTD6/Behaviors/Emissions/EmissionOverTime")]
public class EmissionOverTime : Emission
{
	public int count; //Field offset: 0x30
	public float timeBetween; //Field offset: 0x34

	public virtual EmissionModel Def
	{
		 get { } //Length: 174
	}

	public EmissionOverTime() { }

	public virtual EmissionModel get_Def() { }

}

