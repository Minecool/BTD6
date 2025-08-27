namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class DurableShots : RelicKnowledgeItemBase
{
	public float extraPierce; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public DurableShots() { }

	public virtual KnowledgeEffect GetEffect() { }

}

