namespace Unity.Services.Analytics.Data;

internal class DataGenerator : IDataGenerator
{
	public enum SessionEndState
	{
		PAUSED = 0,
		KILLEDINBACKGROUND = 1,
		KILLEDINFOREGROUND = 2,
		QUIT = 3,
	}

	private IBuffer m_Buffer; //Field offset: 0x10

	public DataGenerator() { }

	public override void GameEnded(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, SessionEndState quitState) { }

	public override void GameRunning(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier) { }

	public override void SetBuffer(IBuffer buffer) { }

}

