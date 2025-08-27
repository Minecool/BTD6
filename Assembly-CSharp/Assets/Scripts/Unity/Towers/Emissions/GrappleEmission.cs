namespace Assets.Scripts.Unity.Towers.Emissions;

public class GrappleEmission : Emission
{
	public GrappleEmission parent; //Field offset: 0x88

	public virtual EmissionModel Def
	{
		 get { } //Length: 158
	}

	public GrappleEmission() { }

	public virtual EmissionModel get_Def() { }

}

