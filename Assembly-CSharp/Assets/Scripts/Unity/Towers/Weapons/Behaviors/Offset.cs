namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class Offset : WeaponBehavior
{
	public Offset parent; //Field offset: 0x90
	public float range; //Field offset: 0x98
	public string expRange; //Field offset: 0xA0
	public float angleOffset; //Field offset: 0xA8
	public string expAngleOffset; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public Offset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

