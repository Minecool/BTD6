namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(LeakDangerAttackSpeed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LeakDangerAttackSpeedModel : WeaponBehaviorModel
{
	public float maxRateIncreasePercent; //Field offset: 0x30

	public LeakDangerAttackSpeedModel(string name, float maxRateIncreasePercent) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

