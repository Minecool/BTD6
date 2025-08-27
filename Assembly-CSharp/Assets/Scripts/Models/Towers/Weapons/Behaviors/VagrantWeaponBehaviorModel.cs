namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(VagrantWeaponBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class VagrantWeaponBehaviorModel : WeaponBehaviorModel
{
	public float noTowersRateBonus; //Field offset: 0x30
	public float towerRangeBonusReduction; //Field offset: 0x34
	public float bloonInRangeAttackSpeedBuff; //Field offset: 0x38
	public float maxBloonAttackSpeedBuff; //Field offset: 0x3C
	public PrefabReference buffDisplay; //Field offset: 0x40
	public string buffLocsName; //Field offset: 0x48
	public string buffLocsFullName; //Field offset: 0x50

	public VagrantWeaponBehaviorModel(string name, float noTowersRateBonus, float towerRangeBonusReduction, float bloonInRangeAttackSpeedBuff, float maxBloonAttackSpeedBuff, string buffLocsName, string buffLocsFullName) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

