namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionRotationOffProjectileDirection : EmissionBehavior
{
	public EmissionRotationOffProjectileDirection parent; //Field offset: 0x88
	public float startingOffset; //Field offset: 0x90
	public string expStartingOffset; //Field offset: 0x98
	public float angleInBetween; //Field offset: 0xA0
	public string expAngleInBetween; //Field offset: 0xA8
	public bool alwaysCentre; //Field offset: 0xB0
	public string expAlwaysCentre; //Field offset: 0xB8

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 157
	}

	public EmissionRotationOffProjectileDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

