namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(RateBasedAnimationOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RateBasedAnimationOffsetModel : WeaponBehaviorModel
{
	public float baseRate; //Field offset: 0x30
	public float offset; //Field offset: 0x34

	public RateBasedAnimationOffsetModel(string name, float baseRate, float offset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

