namespace Assets.Scripts.Unity.Towers.Emissions;

public class SingleEmissionAtTower : Emission
{
	public SingleEmissionAtTower parent; //Field offset: 0x88

	public virtual EmissionModel Def
	{
		 get { } //Length: 158
	}

	public SingleEmissionAtTower() { }

	public virtual EmissionModel get_Def() { }

}

