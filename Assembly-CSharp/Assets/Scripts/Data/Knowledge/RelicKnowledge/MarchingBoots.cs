namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class MarchingBoots : RelicKnowledgeItemBase
{
	public int extraIndividualTowers; //Field offset: 0x38
	public int extraTotalTowers; //Field offset: 0x3C
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public MarchingBoots() { }

	public virtual KnowledgeEffect GetEffect() { }

}

