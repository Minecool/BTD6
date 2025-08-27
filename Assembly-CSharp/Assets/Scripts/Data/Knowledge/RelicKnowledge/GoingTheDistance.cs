namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class GoingTheDistance : RelicKnowledgeItemBase
{
	public float rangeModifier; //Field offset: 0x38
	public float increasedLifespan; //Field offset: 0x3C
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public GoingTheDistance() { }

	public virtual KnowledgeEffect GetEffect() { }

}

