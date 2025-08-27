namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TempleTowerMutatorGroup", menuName = "BTD6/Behaviors/Towers/TempleTowerMutatorGroup")]
public class TempleTowerMutatorGroup : TowerMutatorGroup
{
	public int cost; //Field offset: 0x38
	public string towerSet; //Field offset: 0x40
	public TowerMutator[] towerMutators; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 183
	}

	public TempleTowerMutatorGroup() { }

	public virtual TowerBehaviorModel get_Def() { }

}

