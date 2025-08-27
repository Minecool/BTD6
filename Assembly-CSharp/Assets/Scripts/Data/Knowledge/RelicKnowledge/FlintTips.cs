namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class FlintTips : RelicKnowledgeItemBase
{
	public int damagePerTick; //Field offset: 0x38
	public float timeBetweenTicks; //Field offset: 0x3C
	public float totalDuration; //Field offset: 0x40
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x48

	public FlintTips() { }

	public virtual KnowledgeEffect GetEffect() { }

}

