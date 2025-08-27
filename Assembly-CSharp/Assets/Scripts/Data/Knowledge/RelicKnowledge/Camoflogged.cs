namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class Camoflogged : RelicKnowledgeItemBase
{
	public float extraDamage; //Field offset: 0x38
	[SerializeField]
	[TowerTypes]
	public TargetTowersContainer from; //Field offset: 0x40

	public Camoflogged() { }

	public virtual KnowledgeEffect GetEffect() { }

}

