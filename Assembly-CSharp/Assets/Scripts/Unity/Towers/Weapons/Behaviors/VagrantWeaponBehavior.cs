namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class VagrantWeaponBehavior : WeaponBehavior
{
	public VagrantWeaponBehavior parent; //Field offset: 0x90
	public float noTowersRateBonus; //Field offset: 0x98
	public string expNoTowersRateBonus; //Field offset: 0xA0
	public float towerRangeBonusReduction; //Field offset: 0xA8
	public string expTowerRangeBonusReduction; //Field offset: 0xB0
	public float bloonInRangeAttackSpeedBuff; //Field offset: 0xB8
	public string expBloonInRangeAttackSpeedBuff; //Field offset: 0xC0
	public float maxBloonAttackSpeedBuff; //Field offset: 0xC8
	public string expMaxBloonAttackSpeedBuff; //Field offset: 0xD0
	public string buffLocsName; //Field offset: 0xD8
	public string expBuffLocsName; //Field offset: 0xE0
	public string buffLocsFullName; //Field offset: 0xE8
	public string expBuffLocsFullName; //Field offset: 0xF0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 237
	}

	public VagrantWeaponBehavior() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

