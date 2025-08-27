namespace Assets.Scripts.Unity.Towers.Emissions;

public class InstantDamageEmission : Emission
{
	public InstantDamageEmission parent; //Field offset: 0x88

	public virtual EmissionModel Def
	{
		 get { } //Length: 158
	}

	public InstantDamageEmission() { }

	public virtual EmissionModel get_Def() { }

}

