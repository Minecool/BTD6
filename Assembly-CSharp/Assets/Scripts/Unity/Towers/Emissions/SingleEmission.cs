namespace Assets.Scripts.Unity.Towers.Emissions;

public class SingleEmission : Emission
{
	public SingleEmission parent; //Field offset: 0x88

	public virtual EmissionModel Def
	{
		 get { } //Length: 158
	}

	public SingleEmission() { }

	public virtual EmissionModel get_Def() { }

}

