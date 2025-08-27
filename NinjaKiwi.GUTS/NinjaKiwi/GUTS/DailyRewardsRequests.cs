namespace NinjaKiwi.GUTS;

[Extension]
public static class DailyRewardsRequests
{
	private const string kEmptyPayload = "{}"; //Field offset: 0x0

	[Extension]
	public static Task<DailyRewardsClaimResponse> DAILY_REWARDS_Claim(Player<T> player) { }

	[Extension]
	public static Task<DailyRewardsClaimResponse> DAILY_REWARDS_DEBUG_Reset(Player<T> player) { }

}

