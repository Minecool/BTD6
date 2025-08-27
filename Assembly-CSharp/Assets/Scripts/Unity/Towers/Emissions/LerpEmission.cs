namespace Assets.Scripts.Unity.Towers.Emissions;

public class LerpEmission : Emission
{
	public LerpEmission parent; //Field offset: 0x88

	public virtual EmissionModel Def
	{
		 get { } //Length: 158
	}

	public LerpEmission() { }

	public virtual EmissionModel get_Def() { }

}

