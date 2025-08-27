namespace Assets.Scripts.Simulation.Track.Spawners;

public class RuleSplitter : Splitter
{
	private RuleSplitterModel modl; //Field offset: 0x30

	public RuleSplitter(RuleSplitterModel def) { }

	public virtual Path Rout(BloonModel bloonModel = null) { }

	public virtual Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

}

