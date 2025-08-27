namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CheckAmmoBelt : WeaponBehavior
{
	public CheckAmmoBelt parent; //Field offset: 0x90
	public float fireRate; //Field offset: 0x98
	public string expFireRate; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public CheckAmmoBelt() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

