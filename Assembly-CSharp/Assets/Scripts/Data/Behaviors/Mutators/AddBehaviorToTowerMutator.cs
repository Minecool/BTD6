namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "AddBehaviorToTowerMutator", menuName = "BTD6/Behaviors/Mutators/AddBehaviorToTowerMutator")]
public class AddBehaviorToTowerMutator : TowerMutator
{
	public float lifespan; //Field offset: 0x38
	public TowerBehavior behavior; //Field offset: 0x40

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 439
	}

	public AddBehaviorToTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

