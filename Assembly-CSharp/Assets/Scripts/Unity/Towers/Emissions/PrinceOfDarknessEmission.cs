namespace Assets.Scripts.Unity.Towers.Emissions;

public class PrinceOfDarknessEmission : Emission
{
	public GrappleEmission parent; //Field offset: 0x88
	public int minPiercePerBloon; //Field offset: 0x90
	public string expMinPiercePerBloon; //Field offset: 0x98
	public int maxPathRandomRange; //Field offset: 0xA0
	public string expMaxPathRandomRange; //Field offset: 0xA8
	public int maxPathOffset; //Field offset: 0xB0
	public string expMaxPathOffset; //Field offset: 0xB8
	public Projectile alternateProjectile; //Field offset: 0xC0
	public Projectile expAlternateProjectile; //Field offset: 0xC8

	public virtual EmissionModel Def
	{
		 get { } //Length: 353
	}

	public PrinceOfDarknessEmission() { }

	public virtual EmissionModel get_Def() { }

}

