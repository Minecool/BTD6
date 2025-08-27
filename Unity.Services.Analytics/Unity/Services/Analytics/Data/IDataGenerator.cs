namespace Unity.Services.Analytics.Data;

internal interface IDataGenerator
{

	public void GameEnded(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier, SessionEndState quitState) { }

	public void GameRunning(DateTime datetime, StdCommonParams commonParams, string callingMethodIdentifier) { }

	public void SetBuffer(IBuffer buffer) { }

}

