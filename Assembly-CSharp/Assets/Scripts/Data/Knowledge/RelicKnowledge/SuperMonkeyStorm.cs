namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class SuperMonkeyStorm : RelicKnowledgeItemBase
{
	public int superMonkeyStormPowerupsPerGame; //Field offset: 0x38

	public SuperMonkeyStorm() { }

	public virtual KnowledgeEffect GetEffect() { }

}

