namespace NinjaKiwi.GUTS;

[Extension]
public static class BcsWebRequests
{

	[Extension]
	public static Task<RewardsClaimResponse> BCS_BOSS_ClaimFinalRewards(Player<T> player, string eventId) { }

	[Extension]
	public static Task<RewardsClaimResponse> BCS_BOSS_ClaimStageRewards(Player<T> player, string eventId) { }

	[Extension]
	public static Task<EmptyResponse> BCS_BOSS_DEBUG_Clear(Player<T> player, string eventId) { }

	[Extension]
	public static Task<RewardsClaimResponse> RANKED_ClaimRewards(Player<T> player, string eventId) { }

}

