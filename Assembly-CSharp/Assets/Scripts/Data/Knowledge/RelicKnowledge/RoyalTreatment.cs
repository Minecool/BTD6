namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class RoyalTreatment : RelicKnowledgeItemBase
{
	[SerializeField]
	public BloonProperties removes; //Field offset: 0x38
	[BloonTypes]
	[SerializeField]
	public TargetBloonsContainer from; //Field offset: 0x40
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer appliesTo; //Field offset: 0x48

	public RoyalTreatment() { }

	public virtual KnowledgeEffect GetEffect() { }

}

