namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "AdoraEmission", menuName = "BTD6/Behaviors/Emissions/AdoraEmission")]
public class AdoraEmission : Emission
{
	public int count; //Field offset: 0x30
	public float angleBetween; //Field offset: 0x34

	public virtual EmissionModel Def
	{
		 get { } //Length: 174
	}

	public AdoraEmission() { }

	public virtual EmissionModel get_Def() { }

}

