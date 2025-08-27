namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class BrokenHeart : RelicKnowledgeItemBase
{
	public float extraDamage; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer from; //Field offset: 0x40

	public BrokenHeart() { }

	public virtual KnowledgeEffect GetEffect() { }

}

