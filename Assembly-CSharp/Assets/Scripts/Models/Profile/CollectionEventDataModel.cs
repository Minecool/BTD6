namespace Assets.Scripts.Models.Profile;

public class CollectionEventDataModel
{
	public string eventId; //Field offset: 0x10
	public KonFuze amountCollected; //Field offset: 0x18
	public KonFuze amountRewardedFor; //Field offset: 0x20
	public KonFuze amountLastSeen; //Field offset: 0x28
	public KonFuze seed; //Field offset: 0x30
	public KonFuze[] featuredInstaCharges; //Field offset: 0x38
	public KonFuze lastFeaturedInstasPageSeen; //Field offset: 0x40

	public CollectionEventDataModel() { }

	public CollectionEventDataModel(string eventId, int amountCollected, int amountRewardedFor, int amountLastSeen, int seed, Int32[] featuredInstaCharges, int lastFeaturedInstasPageSeen) { }

}

