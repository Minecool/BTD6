namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class GlueTrap : RelicKnowledgeItemBase
{
	public int glueTrapPowerupsPerGame; //Field offset: 0x38

	public GlueTrap() { }

	public virtual KnowledgeEffect GetEffect() { }

}

