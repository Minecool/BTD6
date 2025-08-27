namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class Spin : WeaponBehavior
{
	public Spin parent; //Field offset: 0x90
	public float rotationPerSecond; //Field offset: 0x98
	public string expRotationPerSecond; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public Spin() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

