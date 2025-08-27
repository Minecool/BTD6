namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(BloonsInRangeAttackSpeed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloonsInRangeAttackSpeedModel : WeaponBehaviorModel
{
	public float rateIncreasePerStack; //Field offset: 0x30
	public int bloonsPerStack; //Field offset: 0x34
	public int maxStacks; //Field offset: 0x38

	public BloonsInRangeAttackSpeedModel(string name, float rateIncreasePerStack, int bloonsPerStack, int maxStacks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

