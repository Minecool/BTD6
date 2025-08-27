namespace Assets.Scripts.Utils;

[Flags]
public enum SocialGameplayType
{
	Unrestricted = 0,
	RequiresOnlineSKU = 1,
	RequiresLiNK = 2,
	InvolvesLeaderboards = 4,
	PlayerCreatedContent = 8,
	RealtimeMultiplayer = 16,
	Friends = 6,
	RaceEvent = 7,
	BossEvent = 7,
	Challenge = 11,
	CustomMap = 11,
	Coop = 17,
	CoopBoss = 23,
	TeamEvent = 7,
	Sweepstakes = 3,
}

