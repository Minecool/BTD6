namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateProjectileOnTowerDestroy", menuName = "BTD6/Behaviors/Towers/CreateProjectileOnTowerDestroy")]
public class CreateProjectileOnTowerDestroy : TowerBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public bool useTowerRotation; //Field offset: 0x40
	public bool setAgeZeroOnSell; //Field offset: 0x41
	public bool ignoreSubtowers; //Field offset: 0x42

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 257
	}

	public CreateProjectileOnTowerDestroy() { }

	public virtual TowerBehaviorModel get_Def() { }

}

