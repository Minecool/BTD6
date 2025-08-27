namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(EmissionsPerRoundFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionsPerRoundFilterModel : WeaponBehaviorModel
{
	public int count; //Field offset: 0x30

	public EmissionsPerRoundFilterModel(string name, int count) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

