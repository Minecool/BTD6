namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class NecroEmissionFilter : WeaponBehavior
{
	public NecroEmissionFilter parent; //Field offset: 0x90
	public string expIsPriceOfDakrnessEmission; //Field offset: 0x98
	public bool isPriceOfDakrnessEmission; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public NecroEmissionFilter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

