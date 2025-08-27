namespace Assets.Scripts.Data.Knowledge.RelicKnowledge;

public class RoadSpikes : RelicKnowledgeItemBase
{
	public int roadSpikeStacksPerGame; //Field offset: 0x38

	public RoadSpikes() { }

	public virtual KnowledgeEffect GetEffect() { }

}

