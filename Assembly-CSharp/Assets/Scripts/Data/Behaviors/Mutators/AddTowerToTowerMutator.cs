namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "AddTowerToTowerMutator", menuName = "BTD6/Behaviors/Mutators/AddTowerToTowerMutator")]
public class AddTowerToTowerMutator : TowerMutator
{
	public Tower tower; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 380
	}

	public AddTowerToTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

