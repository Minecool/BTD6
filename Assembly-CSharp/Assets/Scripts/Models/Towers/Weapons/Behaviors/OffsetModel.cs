namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(Offset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OffsetModel : WeaponBehaviorModel
{
	public float range; //Field offset: 0x30
	public float angleOffset; //Field offset: 0x34

	public OffsetModel(string name, float range, float angleOffset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

