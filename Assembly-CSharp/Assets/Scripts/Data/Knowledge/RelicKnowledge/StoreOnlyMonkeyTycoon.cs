namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class StoreOnlyMonkeyTycoon : RelicKnowledgeItemBase
{
	public float discount; //Field offset: 0x38
	public int extraTowerCount; //Field offset: 0x3C
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public StoreOnlyMonkeyTycoon() { }

	public virtual KnowledgeEffect GetEffect() { }

}

