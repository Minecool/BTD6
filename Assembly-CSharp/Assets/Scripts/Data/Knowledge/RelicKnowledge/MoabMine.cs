namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class MoabMine : RelicKnowledgeItemBase
{
	public int moabMinePowerupsPerGame; //Field offset: 0x38

	public MoabMine() { }

	public virtual KnowledgeEffect GetEffect() { }

}

