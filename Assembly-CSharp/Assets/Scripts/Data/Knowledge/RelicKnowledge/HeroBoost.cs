namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class HeroBoost : RelicKnowledgeItemBase
{
	public float multiplier; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public HeroBoost() { }

	public virtual KnowledgeEffect GetEffect() { }

}

