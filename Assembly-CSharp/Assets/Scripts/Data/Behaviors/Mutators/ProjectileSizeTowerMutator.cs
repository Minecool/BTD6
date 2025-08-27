namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "ProjectileSizeTowerMutator", menuName = "BTD6/Behaviors/Mutators/ProjectileSizeTowerMutator")]
public class ProjectileSizeTowerMutator : TowerMutator
{
	public float sizeModifier; //Field offset: 0x38
	public float assetSizeModifier; //Field offset: 0x3C
	public float lifespan; //Field offset: 0x40

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 340
	}

	public ProjectileSizeTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

