namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "AddAttackTowerMutator", menuName = "BTD6/Behaviors/Mutators/AddAttackTowerMutator")]
public class AddAttackTowerMutator : TowerMutator
{
	public Attack attack; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 380
	}

	public AddAttackTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

