namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Heartless : RelicKnowledgeItemBase
{
	public float regrowRegenRateMultiplier; //Field offset: 0x38
	[SerializeField]
	public BloonKind affects; //Field offset: 0x3C

	public Heartless() { }

	public virtual KnowledgeEffect GetEffect() { }

}

