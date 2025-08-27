namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Abilitized : RelicKnowledgeItemBase
{
	public float abilityCooldownReduction; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public Abilitized() { }

	public virtual KnowledgeEffect GetEffect() { }

}

