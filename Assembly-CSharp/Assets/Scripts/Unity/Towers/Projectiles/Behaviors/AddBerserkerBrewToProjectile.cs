namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AddBerserkerBrewToProjectile : ProjectileBehavior
{
	public string mutationId; //Field offset: 0x88
	public string expMutationId; //Field offset: 0x90
	public float lifespan; //Field offset: 0x98
	public string expLifespan; //Field offset: 0xA0
	public float cap; //Field offset: 0xA8
	public string expCap; //Field offset: 0xB0
	public string ignoreList; //Field offset: 0xB8
	public string expIgnoreList; //Field offset: 0xC0
	public string ignoreMutationsByOrder; //Field offset: 0xC8
	public string expIgnoreMutationsByOrder; //Field offset: 0xD0
	public WeaponBehavior weaponBehavior; //Field offset: 0xD8
	public WeaponBehavior expWeaponBehavior; //Field offset: 0xE0
	public TowerBehavior towerBehavior; //Field offset: 0xE8
	public TowerBehavior expTowerBehavior; //Field offset: 0xF0
	public float rebuffBlockTime; //Field offset: 0xF8
	public string expRebuffBlockTime; //Field offset: 0x100
	public GameObject display; //Field offset: 0x108
	public GameObject expDisplay; //Field offset: 0x110
	public string buffLocsName; //Field offset: 0x118
	public string expBuffLocsName; //Field offset: 0x120
	public string buffIconName; //Field offset: 0x128
	public string expBuffIconName; //Field offset: 0x130
	public string mutatorsToRemove; //Field offset: 0x138
	public string expMutatorsToRemove; //Field offset: 0x140

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1015
	}

	public AddBerserkerBrewToProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

