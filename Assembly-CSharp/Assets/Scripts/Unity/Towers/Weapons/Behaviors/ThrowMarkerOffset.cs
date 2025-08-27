namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ThrowMarkerOffset : WeaponBehavior
{
	public GameObject offset; //Field offset: 0x90
	public GameObject expOffset; //Field offset: 0x98

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 764
	}

	public ThrowMarkerOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

