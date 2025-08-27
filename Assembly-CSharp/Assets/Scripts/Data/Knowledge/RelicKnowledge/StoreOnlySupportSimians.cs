namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class StoreOnlySupportSimians : RelicKnowledgeItemBase
{
	public float discount; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public StoreOnlySupportSimians() { }

	public virtual KnowledgeEffect GetEffect() { }

}

