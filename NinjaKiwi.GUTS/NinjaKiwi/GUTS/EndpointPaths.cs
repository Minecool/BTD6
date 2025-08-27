namespace NinjaKiwi.GUTS;

public static class EndpointPaths
{
	internal static class Game
	{
		internal static class Achievements
		{
			public const string Claim = "/achievements/claim"; //Field offset: 0x0

		}

		internal static class Bcs
		{
			public const string ClaimBossStageRewards = "/bcs/boss/claimStage"; //Field offset: 0x0
			public const string ClaimBossFinalRewards = "/bcs/boss/claimEnd"; //Field offset: 0x0
			public const string DEBUG_BossClear = "/bcs/boss/debug/clear"; //Field offset: 0x0
			public const string ClaimRankedRewards = "/ranked/claim"; //Field offset: 0x0

		}

		internal static class CardPack
		{
			public const string Open = "/cardPack/open"; //Field offset: 0x0

		}

		internal static class ContentBrowser
		{
			internal static class Curation
			{
				public const string Update = "/contentBrowser/curation/update"; //Field offset: 0x0
				public const string GetList = "/contentBrowser/curation/getList"; //Field offset: 0x0
				public const string Search = "/contentBrowser/curation/search"; //Field offset: 0x0

			}

			public const string Submit = "/content/submit"; //Field offset: 0x0
			public const string Report = "/contentBrowser/report"; //Field offset: 0x0
			public const string GetInfo = "/contentBrowser/getInfo"; //Field offset: 0x0
			public const string BuyAccolades = "/contentBrowser/accolades/buy"; //Field offset: 0x0
			public const string GetAccolades = "/contentBrowser/accolades/get"; //Field offset: 0x0

		}

		internal static class DailyRewards
		{
			public const string Claim = "/dailyRewards/claim"; //Field offset: 0x0
			public const string DEBUG_Reset = "/dailyRewards/debug/reset"; //Field offset: 0x0

		}

		internal static class DailyStore
		{
			public const string Get = "/bcs/dailyStore/get"; //Field offset: 0x0
			public const string Reroll = "/bcs/dailyStore/reroll"; //Field offset: 0x0
			public const string Claim = "/bcs/dailyStore/claim"; //Field offset: 0x0

		}

		internal static class Quests
		{
			public const string Get = "/quests/get"; //Field offset: 0x0
			public const string Claim = "/quests/claim"; //Field offset: 0x0
			public const string Reroll = "/quests/reroll"; //Field offset: 0x0

		}

		internal static class Sweepstakes
		{
			public const string GetStatus = "/sweepstakes/getStatus"; //Field offset: 0x0
			public const string ClaimTickets = "/sweepstakes/claim"; //Field offset: 0x0
			public const string MultiClaimTickets = "/sweepstakes/multiClaim"; //Field offset: 0x0
			public const string SeeShareCode = "/sweepstakes/seeShareCode"; //Field offset: 0x0
			public const string ShareCode = "/sweepstakes/shareCode"; //Field offset: 0x0
			public const string CanParticipate = "/sweepstakes/canParticipate"; //Field offset: 0x0
			public const string GetWinners = "/sweepstakes/getWinners"; //Field offset: 0x0
			public const string DEBUG_Reset = "/sweepstakes/debug/reset"; //Field offset: 0x0
			public const string DEBUG_Unlock = "/sweepstakes/debug/unlock"; //Field offset: 0x0

		}


	}

	internal static class Guilds
	{
		internal class BossRush
		{
			public const string GetStatus = "/bossRush/getStatus"; //Field offset: 0x0
			public const string SubmitScore = "/bossRush/submitScore"; //Field offset: 0x0
			public const string GetScores = "/bossRush/getScores"; //Field offset: 0x0
			public const string ClaimTeamTrophies = "/bossRush/claimTeamTrophies"; //Field offset: 0x0
			public const string GetCompletedTier = "/bossRush/completed"; //Field offset: 0x0

			public BossRush() { }

		}

		internal static class Ct
		{
			internal static class Activity
			{
				public const string Get = "/activity/get"; //Field offset: 0x0
				public const string Set = "/activity/set"; //Field offset: 0x0

			}

			internal static class Competitive
			{
				public const string SetStance = "/competitive/setStance"; //Field offset: 0x0
				public const string Get = "/competitive/get"; //Field offset: 0x0

			}

			internal static class Relics
			{
				public const string Get = "/relics/get"; //Field offset: 0x0

			}

			internal static class Score
			{
				public const string Set = "/score/set"; //Field offset: 0x0
				public const string Start = "/score/start"; //Field offset: 0x0

			}

			internal static class Search
			{
				public const string Instance = "/search/instance"; //Field offset: 0x0
				public const string UserIds = "/search/userIds"; //Field offset: 0x0

			}

			internal static class Status
			{
				public const string Instance = "/status/instance"; //Field offset: 0x0
				public const string Node = "/status/node"; //Field offset: 0x0

			}

			internal static class Ticket
			{
				public const string Purchase = "/ticket/purchase"; //Field offset: 0x0
				public const string Status = "/ticket/status"; //Field offset: 0x0
				public const string Claim = "/ticket/claim"; //Field offset: 0x0

			}

			internal static class User
			{
				public const string ClaimBonusRewards = "/user/claimbonus"; //Field offset: 0x0

			}

			public const string Register = "/register"; //Field offset: 0x0

		}

		internal static class Guild
		{
			public const string Kick = "/guild/kick"; //Field offset: 0x0
			public const string KickUndo = "/guild/undoKick"; //Field offset: 0x0

		}

		internal static class TeamStore
		{
			public const string Contribute = "/store/contribute"; //Field offset: 0x0

		}


	}


}

