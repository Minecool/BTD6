namespace Assets.Scripts.Unity.Towers.Emissions;

public class MultiEmission : Emission
{
	public MultiEmission parent; //Field offset: 0x88
	public Projectile secondaryProjectile; //Field offset: 0x90
	public Projectile expSecondaryProjectile; //Field offset: 0x98

	public virtual EmissionModel Def
	{
		 get { } //Length: 204
	}

	public MultiEmission() { }

	public virtual EmissionModel get_Def() { }

}

