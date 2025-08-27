namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "SetTriggerOnAirUnitFire", menuName = "BTD6/Behaviors/Weapons/SetTriggerOnAirUnitFire")]
public class SetTriggerOnAirUnitFire : WeaponBehavior
{
	public int triggerState; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public SetTriggerOnAirUnitFire() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

