namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class SetTriggerOnAirUnitFire : WeaponBehavior
{
	public SetTriggerOnAirUnitFire parent; //Field offset: 0x90
	public int triggerState; //Field offset: 0x98
	public string expTriggerState; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public SetTriggerOnAirUnitFire() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

