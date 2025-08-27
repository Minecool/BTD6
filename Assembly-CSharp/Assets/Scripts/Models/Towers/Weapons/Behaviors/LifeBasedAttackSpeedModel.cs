namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(LifeBasedAttackSpeed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LifeBasedAttackSpeedModel : WeaponBehaviorModel
{
	public float ratePerLife; //Field offset: 0x30
	public int lifeCap; //Field offset: 0x34
	public float baseRateIncrease; //Field offset: 0x38
	public string saveId; //Field offset: 0x40

	public LifeBasedAttackSpeedModel(string name, float ratePerLife, int lifeCap, float baseRateIncrease, string saveId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

