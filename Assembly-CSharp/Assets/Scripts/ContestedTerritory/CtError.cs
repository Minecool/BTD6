namespace Assets.Scripts.ContestedTerritory;

public enum CtError
{
	SetBaseTileType_TargetNotRegular = 0,
	AssignTeam_NotStartArea = 1,
	GenerateRules_GameSettingsNotFound = 2,
	AddRelicKnowledge_NonRelicTile = 3,
	GetTileTypeForReward_NonCapturableTile = 4,
	GetCoordinateForTeamIsland_NotStartArea = 5,
	GetBossType_NonBossTile = 6,
	SetMap_GameDifficultyNotFound = 7,
	SetVictoryCondition_NotImplemented = 8,
	SetBoss_NotImplemented = 9,
	SetGameMode_NotImplemented = 10,
	SetModifiers_NotImplemented = 11,
	SyncGameBoardToLastMapState_GameBoardNotBuilt = 12,
	SyncMapToServerState_MapNotBuilt = 13,
	GetRandomFloatIndex_Failed = 14,
	GenerateRandomIndexList_CountLargerThanList = 15,
	GetRandomValue_Failed = 16,
	GetRandomiserSeed_NoActiveEvent = 17,
	PlayRefreshAnimation_NoCompletedTile = 18,
	PerformFirstFullSyncIfRequired_ApiFailedToRefresh = 19,
	SyncMapToServerState_ApiFailedToRefresh = 20,
}

