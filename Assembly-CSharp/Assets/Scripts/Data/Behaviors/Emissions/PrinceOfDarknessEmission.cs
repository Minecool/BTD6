namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "PrinceOfDarknessEmission", menuName = "BTD6/Behaviors/Emissions/PrinceOfDarknessEmission")]
public class PrinceOfDarknessEmission : Emission
{
	public int minPiercePerBloon; //Field offset: 0x30
	public int maxPathRandomRange; //Field offset: 0x34
	public int maxPathOffset; //Field offset: 0x38
	public Projectile projectile; //Field offset: 0x40

	public virtual EmissionModel Def
	{
		 get { } //Length: 238
	}

	public PrinceOfDarknessEmission() { }

	public virtual EmissionModel get_Def() { }

}

