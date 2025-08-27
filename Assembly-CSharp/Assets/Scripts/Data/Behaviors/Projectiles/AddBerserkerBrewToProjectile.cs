namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddBerserkerBrewToProjectile", menuName = "BTD6/Behaviors/Projectiles/AddBerserkerBrewToProjectile")]
public class AddBerserkerBrewToProjectile : ProjectileBehavior
{
	public string mutationId; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public float cap; //Field offset: 0x3C
	public string ignoreList; //Field offset: 0x40
	public string ignoreMutationsByOrder; //Field offset: 0x48
	public WeaponBehavior weaponBehavior; //Field offset: 0x50
	public TowerBehavior towerBehavior; //Field offset: 0x58
	public float rebuffBlockTime; //Field offset: 0x60
	public PrefabReference display; //Field offset: 0x68
	public string buffLocsName; //Field offset: 0x70
	public string buffIconName; //Field offset: 0x78
	public string mutatorsToRemove; //Field offset: 0x80
	public BerserkerBrew berserkerBrew; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 867
	}

	public AddBerserkerBrewToProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

