namespace Assets.Scripts.Models.Profile;

public class PlayerSaveData
{
	public int index; //Field offset: 0x10
	public double cash; //Field offset: 0x18
	public string hero; //Field offset: 0x20
	public List<FreeTowerSaveDataModel> freeTowers; //Field offset: 0x28
	public List<TowerDiscountSaveDataModel> towerDiscounts; //Field offset: 0x30
	public List<GeraldoStockItem> geraldoShopItems; //Field offset: 0x38
	public bool lvl20GeraldoRestockApplied; //Field offset: 0x40
	public bool hasPlacedHero; //Field offset: 0x41

	public PlayerSaveData() { }

}

