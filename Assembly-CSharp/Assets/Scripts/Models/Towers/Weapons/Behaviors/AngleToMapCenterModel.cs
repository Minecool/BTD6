namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(AngleToMapCenter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AngleToMapCenterModel : WeaponBehaviorModel
{
	public float range; //Field offset: 0x30
	public float offset; //Field offset: 0x34

	public AngleToMapCenterModel(string name, float range, float offset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

