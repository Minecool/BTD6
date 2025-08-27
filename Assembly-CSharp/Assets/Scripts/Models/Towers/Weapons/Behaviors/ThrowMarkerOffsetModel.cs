namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(ThrowMarkerOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ThrowMarkerOffsetModel : WeaponBehaviorModel
{
	public float ejectX; //Field offset: 0x30
	public float ejectY; //Field offset: 0x34
	public float ejectZ; //Field offset: 0x38
	public float rotation; //Field offset: 0x3C

	public ThrowMarkerOffsetModel(string name, float ejectX, float ejectY, float ejectZ, float rotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

