namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Regeneration : RelicKnowledgeItemBase
{
	public float livesRestored; //Field offset: 0x38
	public float maxLivesAboveStartingLives; //Field offset: 0x3C

	public Regeneration() { }

	public virtual KnowledgeEffect GetEffect() { }

}

