namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class UseParentEject : WeaponBehavior
{
	public UseParentEject parent; //Field offset: 0x90

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public UseParentEject() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

