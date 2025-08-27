namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class WobbleMeshDisplay : WeaponBehavior
{
	public WobbleMeshDisplay parent; //Field offset: 0x90
	public float min; //Field offset: 0x98
	public string expMin; //Field offset: 0xA0
	public float max; //Field offset: 0xA8
	public string expMax; //Field offset: 0xB0
	public float time; //Field offset: 0xB8
	public string expTime; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 164
	}

	public WobbleMeshDisplay() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

