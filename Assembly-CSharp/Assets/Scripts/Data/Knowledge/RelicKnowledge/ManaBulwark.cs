namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class ManaBulwark : RelicKnowledgeItemBase
{
	public float shieldPerRound; //Field offset: 0x38
	public float maxShield; //Field offset: 0x3C

	public ManaBulwark() { }

	public virtual KnowledgeEffect GetEffect() { }

}

