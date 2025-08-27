namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class StartingStash : RelicKnowledgeItemBase
{
	public float extraCash; //Field offset: 0x38

	public StartingStash() { }

	public virtual KnowledgeEffect GetEffect() { }

}

