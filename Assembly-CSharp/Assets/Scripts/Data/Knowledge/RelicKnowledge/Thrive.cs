namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Thrive : RelicKnowledgeItemBase
{
	public int thrivePowerupsPerGame; //Field offset: 0x38

	public Thrive() { }

	public virtual KnowledgeEffect GetEffect() { }

}

