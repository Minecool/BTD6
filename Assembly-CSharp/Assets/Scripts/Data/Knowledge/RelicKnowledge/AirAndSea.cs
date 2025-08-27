namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class AirAndSea : RelicKnowledgeItemBase
{
	public float costReduction; //Field offset: 0x38
	public float reloadReduction; //Field offset: 0x3C
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public AirAndSea() { }

	public virtual KnowledgeEffect GetEffect() { }

}

