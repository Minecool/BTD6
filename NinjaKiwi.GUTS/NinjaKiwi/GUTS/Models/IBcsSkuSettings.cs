namespace NinjaKiwi.GUTS.Models;

[NullableContext(1)]
public interface IBcsSkuSettings
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1, 1, 1}])]
	public Dictionary<String, Dictionary`2<BcsCardRarity, Dictionary`2<String, Single>>> CardRollWeights
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Dictionary<String, Dictionary`2<BcsCardRarity, Dictionary`2<String, Single>>> get_CardRollWeights() { }

	public void set_CardRollWeights(Dictionary<String, Dictionary`2<BcsCardRarity, Dictionary`2<String, Single>>> value) { }

	public bool TryGetCardRollWeights(string cardRollWeightsId, out Dictionary<BcsCardRarity, Dictionary`2<String, Single>>& cardRollWeights) { }

}

