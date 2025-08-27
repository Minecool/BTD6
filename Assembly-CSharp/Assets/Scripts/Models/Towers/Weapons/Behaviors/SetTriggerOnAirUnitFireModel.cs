namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(SetTriggerOnAirUnitFire), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetTriggerOnAirUnitFireModel : WeaponBehaviorModel
{
	public int triggerState; //Field offset: 0x30

	public SetTriggerOnAirUnitFireModel(string name, int animationState) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

