namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(BurstWeaponBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BurstWeaponBehaviorModel : WeaponBehaviorModel
{
	public float interval; //Field offset: 0x30
	public int intervalFrames; //Field offset: 0x34
	public int count; //Field offset: 0x38
	public bool alwaysEmptyClip; //Field offset: 0x3C

	public BurstWeaponBehaviorModel(string name, float interval, int count, bool alwaysEmptyClip) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

