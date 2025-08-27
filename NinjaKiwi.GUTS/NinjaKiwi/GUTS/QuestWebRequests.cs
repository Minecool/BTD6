namespace NinjaKiwi.GUTS;

[Extension]
public static class QuestWebRequests
{
	private const string kEmptyPayload = "{}"; //Field offset: 0x0

	[Extension]
	public static Task<ClaimQuestsResponse> QUESTS_Claim(Player<T> player, string questId) { }

	[Extension]
	public static Task<GetQuestsResponse> QUESTS_Get(Player<T> player) { }

	[Extension]
	public static Task<RerollQuestResponse> QUESTS_Reroll(Player<T> player, string questId) { }

}

