namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class BiggerBloonSabotage : RelicKnowledgeItemBase
{
	public float healthReduction; //Field offset: 0x38
	public float slowModifier; //Field offset: 0x3C
	[BloonTypes]
	[SerializeField]
	public TargetBloonsContainer affects; //Field offset: 0x40

	public BiggerBloonSabotage() { }

	public virtual KnowledgeEffect GetEffect() { }

}

