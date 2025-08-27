namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class MonkeyBoost : RelicKnowledgeItemBase
{
	public int monkeyBoostPowerupsPerGame; //Field offset: 0x38

	public MonkeyBoost() { }

	public virtual KnowledgeEffect GetEffect() { }

}

