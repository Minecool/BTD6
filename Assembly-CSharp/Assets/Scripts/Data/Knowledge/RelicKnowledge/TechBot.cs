namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class TechBot : RelicKnowledgeItemBase
{
	public int techBotPowerupsPerGame; //Field offset: 0x38

	public TechBot() { }

	public virtual KnowledgeEffect GetEffect() { }

}

