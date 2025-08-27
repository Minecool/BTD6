namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "LoadAlchemistBrewInfo", menuName = "BTD6/Behaviors/Towers/LoadAlchemistBrewInfo")]
public class LoadAlchemistBrewInfo : TowerBehavior
{
	public AddBerserkerBrewToProjectile addBerserkerBrewToProjectile; //Field offset: 0x30
	public AddAcidicMixtureToProjectile addAcidicMixtureToProjectile; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 360
	}

	public LoadAlchemistBrewInfo() { }

	public virtual TowerBehaviorModel get_Def() { }

}

