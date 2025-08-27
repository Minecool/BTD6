namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AddAcidicMixtureToProjectile", menuName = "BTD6/Behaviors/Projectiles/AddAcidicMixtureToProjectile")]
public class AddAcidicMixtureToProjectile : ProjectileBehavior
{
	public float cap; //Field offset: 0x30
	public string ignoreList; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40
	public TowerBehavior towerBehavior; //Field offset: 0x48
	public PrefabReference display; //Field offset: 0x50
	public WeaponBehavior weaponBehavior; //Field offset: 0x58
	public AcidicMixture acidicMixture; //Field offset: 0x60
	public string buffLocsName; //Field offset: 0x68
	public string buffIconName; //Field offset: 0x70

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 833
	}

	public AddAcidicMixtureToProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

