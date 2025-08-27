namespace NinjaKiwi.GUTS;

[Extension]
public static class DailyStoreWebRequests
{
	private const string kEmptyPayload = "{}"; //Field offset: 0x0

	[Extension]
	public static Task<OpenCardPackResponse> CARDPACK_Open(Player<T> player, string cardPackId) { }

	[Extension]
	private static Task<DailyStoreClaimResponse> DAILYSTORE_Claim(Player<T> player, DailyStoreClaimType claimType, BcsCardRarity cardType, int tokenIndex) { }

	[Extension]
	public static Task<DailyStoreClaimResponse> DAILYSTORE_ClaimCard(Player<T> player, BcsCardRarity cardType) { }

	[Extension]
	public static Task<DailyStoreClaimResponse> DAILYSTORE_ClaimToken(Player<T> player, int tokenIndex) { }

	[Extension]
	public static Task<DailyStoreGetResponse> DAILYSTORE_Get(Player<T> player) { }

	[Extension]
	public static Task<DailyStoreGetResponse> DAILYSTORE_Reroll(Player<T> player) { }

}

