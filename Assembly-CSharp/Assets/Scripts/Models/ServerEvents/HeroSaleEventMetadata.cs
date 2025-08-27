namespace Assets.Scripts.Models.ServerEvents;

public class HeroSaleEventMetadata : NewsBannerMetadata
{
	public string hero; //Field offset: 0x20
	public int heroPrice; //Field offset: 0x28
	public int skinPrice; //Field offset: 0x2C
	public int minRank; //Field offset: 0x30
	public int maxRank; //Field offset: 0x34
	public int maxHeroes; //Field offset: 0x38

	public HeroSaleEventMetadata() { }

	public bool IsHeroOnSale(string heroId) { }

}

