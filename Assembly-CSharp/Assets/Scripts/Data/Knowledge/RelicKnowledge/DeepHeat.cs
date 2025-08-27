namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class DeepHeat : RelicKnowledgeItemBase
{
	[SerializeField]
	public BloonProperties removes; //Field offset: 0x38
	[BloonTypes]
	[SerializeField]
	public TargetBloonsContainer from; //Field offset: 0x40
	public int extraFreezeLayers; //Field offset: 0x48
	public float extraFreezeDuration; //Field offset: 0x4C

	public DeepHeat() { }

	public virtual KnowledgeEffect GetEffect() { }

}

