namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class AlchemistTouch : RelicKnowledgeItemBase
{
	[SerializeField]
	public BloonProperties removes; //Field offset: 0x38
	[BloonTypes]
	[SerializeField]
	public TargetBloonsContainer from; //Field offset: 0x40
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer appliesTo; //Field offset: 0x48

	public AlchemistTouch() { }

	public virtual KnowledgeEffect GetEffect() { }

}

