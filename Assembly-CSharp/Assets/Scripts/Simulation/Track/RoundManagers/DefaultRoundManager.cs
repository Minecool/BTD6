namespace Assets.Scripts.Simulation.Track.RoundManagers;

public class DefaultRoundManager : RoundManager
{
	private GameModel model; //Field offset: 0x10

	private RoundSetModel RoundSet
	{
		private get { } //Length: 30
	}

	public DefaultRoundManager(GameModel model) { }

	private RoundSetModel get_RoundSet() { }

	public virtual int GetMaxRound() { }

	public virtual BloonEmissionModel[] GetRoundEmissions(int roundArrayIndex) { }

}

