namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(BloonDistanceRateBonus), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloonDistanceRateBonusModel : WeaponBehaviorModel
{
	public float rateBonusPerRange; //Field offset: 0x30
	public int rangeMax; //Field offset: 0x34

	public BloonDistanceRateBonusModel(string name, float rateBonusPerRange, int rangeMax) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

