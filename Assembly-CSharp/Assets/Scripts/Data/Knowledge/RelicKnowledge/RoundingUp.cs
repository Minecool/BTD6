namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class RoundingUp : RelicKnowledgeItemBase
{
	public float extraCashPerRound; //Field offset: 0x38

	public RoundingUp() { }

	public virtual KnowledgeEffect GetEffect() { }

}

