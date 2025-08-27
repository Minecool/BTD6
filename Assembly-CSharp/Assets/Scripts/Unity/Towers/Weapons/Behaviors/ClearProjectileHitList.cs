namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ClearProjectileHitList : WeaponBehavior
{
	public ClearProjectileHitList parent; //Field offset: 0x90
	public float rate; //Field offset: 0x98
	public string expRate; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public ClearProjectileHitList() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

