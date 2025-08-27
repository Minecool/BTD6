namespace Assets.Scripts.Unity.Towers.Behaviors;

public class LoadAlchemistBrewInfo : TowerBehavior
{
	public LoadAlchemistBrewInfo parent; //Field offset: 0x98
	public AddBerserkerBrewToProjectile addBerserkerBrewToProjectile; //Field offset: 0xA0
	public AddBerserkerBrewToProjectile expAddBerserkerBrewToProjectile; //Field offset: 0xA8
	public AddAcidicMixtureToProjectile addAcidicMixtureToProjectile; //Field offset: 0xB0
	public AddAcidicMixtureToProjectile expAddAcidicMixtureToProjectile; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 366
	}

	public LoadAlchemistBrewInfo() { }

	public virtual TowerBehaviorModel get_Def() { }

}

