namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "ProjectileSpeedTowerMutator", menuName = "BTD6/Behaviors/Mutators/ProjectileSpeedTowerMutator")]
public class ProjectileSpeedTowerMutator : TowerMutator
{
	public float speedModifier; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 310
	}

	public ProjectileSpeedTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

