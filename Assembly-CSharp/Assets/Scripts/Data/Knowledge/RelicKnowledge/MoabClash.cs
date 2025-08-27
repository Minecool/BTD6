namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class MoabClash : RelicKnowledgeItemBase
{
	public float extraDamage; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer from; //Field offset: 0x40

	public MoabClash() { }

	public virtual KnowledgeEffect GetEffect() { }

}

