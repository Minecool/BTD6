namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddAcidicMixtureToProjectile : ProjectileBehavior
{
	public float cap; //Field offset: 0x88
	public string expCap; //Field offset: 0x90
	public string ignoreList; //Field offset: 0x98
	public string expIgnoreList; //Field offset: 0xA0
	public string mutationId; //Field offset: 0xA8
	public string expMutationId; //Field offset: 0xB0
	public TowerBehavior towerBehavior; //Field offset: 0xB8
	public TowerBehavior expTowerBehavior; //Field offset: 0xC0
	public GameObject display; //Field offset: 0xC8
	public GameObject expDisplay; //Field offset: 0xD0
	public WeaponBehavior weaponBehavior; //Field offset: 0xD8
	public WeaponBehavior expWeaponBehavior; //Field offset: 0xE0
	public string buffLocsName; //Field offset: 0xE8
	public string expBuffLocsName; //Field offset: 0xF0
	public string buffIconName; //Field offset: 0xF8
	public string expBuffIconName; //Field offset: 0x100

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 972
	}

	public AddAcidicMixtureToProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

