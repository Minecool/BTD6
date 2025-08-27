namespace Assets.Scripts.Models.ServerEvents;

public class GiftEvent : ServerEvent<GiftEventMetadata>
{

	public GiftEvent() { }

	public LootSet GetLootSet() { }

	private static bool TryParseCsv(string csv, out HashSet<String>& csvItems) { }

	private static bool TryParsePowers(string powersCsv, out Dictionary<String, Int32>& powers) { }

}

