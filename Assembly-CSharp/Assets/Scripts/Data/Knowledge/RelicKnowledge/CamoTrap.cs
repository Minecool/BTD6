namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class CamoTrap : RelicKnowledgeItemBase
{
	public int camoTrapPowerupsPerGame; //Field offset: 0x38

	public CamoTrap() { }

	public virtual KnowledgeEffect GetEffect() { }

}

