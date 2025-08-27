namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CritMultiplier), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CritMultiplierModel : WeaponBehaviorModel
{
	public float damage; //Field offset: 0x30
	public int lower; //Field offset: 0x34
	public int upper; //Field offset: 0x38
	public DisplayModel displayModel; //Field offset: 0x40
	public bool distributeToChildren; //Field offset: 0x48

	public CritMultiplierModel(string name, float damage, int lower, int upper, DisplayModel displayModel, bool distributeToChildren) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

