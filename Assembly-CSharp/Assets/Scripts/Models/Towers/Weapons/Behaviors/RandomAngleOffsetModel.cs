namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(RandomAngleOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomAngleOffsetModel : WeaponBehaviorModel
{
	public int minOffset; //Field offset: 0x30
	public int maxOffset; //Field offset: 0x34

	public RandomAngleOffsetModel(string name, int minOffset, int maxOffset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

