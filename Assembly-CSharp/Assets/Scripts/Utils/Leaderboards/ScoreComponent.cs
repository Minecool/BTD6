namespace Assets.Scripts.Utils.Leaderboards;

[Flags]
public enum ScoreComponent
{
	SubmissionTime = 1,
	SubmissionTimeLowAcc = 2,
	GameTimeHighAcc = 4,
	GameTimeLowAcc = 8,
	LeastTiers = 16,
	LeastCash = 32,
	BossTier = 64,
}

