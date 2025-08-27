namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(LoadAlchemistBrewInfo), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LoadAlchemistBrewInfoModel : TowerBehaviorModel
{
	public AddBerserkerBrewToProjectileModel addBerserkerBrewToProjectileModel; //Field offset: 0x30
	public AddAcidicMixtureToProjectileModel addAcidicMixtureToProjectileModel; //Field offset: 0x38

	public LoadAlchemistBrewInfoModel(string name, AddBerserkerBrewToProjectileModel addBerserkerBrewToProjectile, AddAcidicMixtureToProjectileModel addAcidicMixtureToProjectileModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

