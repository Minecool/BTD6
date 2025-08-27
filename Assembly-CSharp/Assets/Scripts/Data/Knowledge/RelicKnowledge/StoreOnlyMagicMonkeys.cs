namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class StoreOnlyMagicMonkeys : RelicKnowledgeItemBase
{
	public float discount; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public StoreOnlyMagicMonkeys() { }

	public virtual KnowledgeEffect GetEffect() { }

}

