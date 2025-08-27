namespace Assets.Scripts.Simulation.Track.Spawners;

public class ToggleSplitter : Splitter
{
	public bool isOn; //Field offset: 0x30

	public ToggleSplitter(ToggleSplitterModel def) { }

	public Path GetCurrentActivePath() { }

	public virtual int GetNumberOfUniqueRounds() { }

	public virtual Path Rout(BloonModel bloonModel = null) { }

	public virtual Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

}

