namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class BoxOfChocolates : RelicKnowledgeItemBase
{
	public int extraLives; //Field offset: 0x38

	public BoxOfChocolates() { }

	public virtual KnowledgeEffect GetEffect() { }

}

