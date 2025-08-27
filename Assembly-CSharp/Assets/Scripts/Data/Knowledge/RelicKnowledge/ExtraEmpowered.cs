namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class ExtraEmpowered : RelicKnowledgeItemBase
{
	public int extraHeroLevels; //Field offset: 0x38
	public int levelsWithEmpoweredHeroes; //Field offset: 0x3C
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer affects; //Field offset: 0x40

	public ExtraEmpowered() { }

	public virtual KnowledgeEffect GetEffect() { }

}

