namespace Assets.Scripts.Unity.UI_New.TrophyStore;

public class TrophyItemBinding
{
	public TrophyStoreItem trophyStoreItem; //Field offset: 0x10
	public bool isPurchased; //Field offset: 0x18
	public bool isFeatured; //Field offset: 0x19
	public bool onSale; //Field offset: 0x1A
	public bool isEnabled; //Field offset: 0x1B
	public bool isLimitedTime; //Field offset: 0x1C
	public DateTime saleEndDate; //Field offset: 0x20
	public int basePrice; //Field offset: 0x28
	public int salePrice; //Field offset: 0x2C
	public Nullable<Boolean> isNew; //Field offset: 0x30

	public TrophyItemBinding() { }

}

