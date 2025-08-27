namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddAcidicMixtureToProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddAcidicMixtureToProjectileModel : ProjectileBehaviorModel
{
	internal class AddAcidicMixtureToProjectileMutator : BehaviorMutator
	{
		public AddAcidicMixtureToProjectileModel acidModel; //Field offset: 0x70

		public AddAcidicMixtureToProjectileMutator(AddAcidicMixtureToProjectileModel acidModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutationId; //Field offset: 0x38
	public int cap; //Field offset: 0x40
	public TowerBehaviorModel[] towerBehaviors; //Field offset: 0x48
	public WeaponBehaviorModel[] weapBehaviors; //Field offset: 0x50
	public ProjectileBehaviorModel[] projBehaviors; //Field offset: 0x58
	public PrefabReference assetId; //Field offset: 0x60
	public string ignoreList; //Field offset: 0x68
	public string buffLocsName; //Field offset: 0x70
	public string buffIconName; //Field offset: 0x78
	private AddAcidicMixtureToProjectileMutator mutator; //Field offset: 0x80

	public AddAcidicMixtureToProjectileMutator Mutator
	{
		 get { } //Length: 277
	}

	public AddAcidicMixtureToProjectileModel(string name, string mutationId, int cap, TowerBehaviorModel[] towerBehaviors, WeaponBehaviorModel[] weapBehaviors, ProjectileBehaviorModel[] projBehaviors, PrefabReference assetId, string ignoreList, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public AddAcidicMixtureToProjectileMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

