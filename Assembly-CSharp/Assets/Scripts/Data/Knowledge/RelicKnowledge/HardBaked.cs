namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class HardBaked : RelicKnowledgeItemBase
{
	public float extraDamage; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer from; //Field offset: 0x40

	public HardBaked() { }

	public virtual KnowledgeEffect GetEffect() { }

}

