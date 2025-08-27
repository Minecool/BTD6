namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "MultiEmission", menuName = "BTD6/Behaviors/Emissions/MultiEmission")]
public class MultiEmission : Emission
{
	public Projectile secondaryProjectile; //Field offset: 0x30

	public virtual EmissionModel Def
	{
		 get { } //Length: 187
	}

	public MultiEmission() { }

	public virtual EmissionModel get_Def() { }

}

