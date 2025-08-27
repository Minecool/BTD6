namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class SubTowerFilter : WeaponBehavior
{
	public SubTowerFilter parent; //Field offset: 0x90
	public string baseSubTowerId; //Field offset: 0x98
	public string expBaseSubTowerId; //Field offset: 0xA0
	public float maxNumberOfSubTowers; //Field offset: 0xA8
	public string expMaxNumberOfSubTowers; //Field offset: 0xB0
	public bool checkForPreExisting; //Field offset: 0xB8
	public string expCheckForPreExisting; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public SubTowerFilter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

