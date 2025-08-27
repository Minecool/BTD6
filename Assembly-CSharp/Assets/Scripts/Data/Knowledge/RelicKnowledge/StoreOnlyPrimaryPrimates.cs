namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class StoreOnlyPrimaryPrimates : RelicKnowledgeItemBase
{
	public float discount; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public StoreOnlyPrimaryPrimates() { }

	public virtual KnowledgeEffect GetEffect() { }

}

