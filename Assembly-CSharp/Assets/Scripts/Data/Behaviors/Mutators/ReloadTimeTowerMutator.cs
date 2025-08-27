namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "ReloadTimeTowerMutator", menuName = "BTD6/Behaviors/Mutators/ReloadTimeTowerMutator")]
public class ReloadTimeTowerMutator : TowerMutator
{
	public float multiplier; //Field offset: 0x38
	public float lifespan; //Field offset: 0x3C

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 310
	}

	public ReloadTimeTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

