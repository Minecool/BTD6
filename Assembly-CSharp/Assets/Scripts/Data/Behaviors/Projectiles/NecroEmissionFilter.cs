namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "NecroEmissionFilter", menuName = "BTD6/Behaviors/Projectiles/NecroEmissionFilter")]
public class NecroEmissionFilter : WeaponBehavior
{
	public bool isPriceOfDakrnessEmission; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public NecroEmissionFilter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

