namespace Assets.Scripts.ContestedTerritory.Api;

public enum CtApiErrorAction
{
	Ignorable_LogErrorMessage = 0,
	NonFatal_RetryLastAction = 1,
	Fatal_RestartContestedTerritory = 2,
}

