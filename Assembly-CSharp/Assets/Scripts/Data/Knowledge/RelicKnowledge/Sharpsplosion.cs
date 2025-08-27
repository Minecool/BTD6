namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Sharpsplosion : RelicKnowledgeItemBase
{
	[SerializeField]
	public BloonProperties removes; //Field offset: 0x38
	[BloonTypes]
	[SerializeField]
	public TargetBloonsContainer from; //Field offset: 0x40

	public Sharpsplosion() { }

	public virtual KnowledgeEffect GetEffect() { }

}

