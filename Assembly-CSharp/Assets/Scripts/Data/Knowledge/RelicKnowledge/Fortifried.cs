namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Fortifried : RelicKnowledgeItemBase
{
	public float extraDamage; //Field offset: 0x38
	[SerializeField]
	public BloonKind to; //Field offset: 0x3C
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer from; //Field offset: 0x40

	public Fortifried() { }

	public virtual KnowledgeEffect GetEffect() { }

}

