namespace Assets.Scripts.Data;

[CreateAssetMenu(fileName = "PowersProData", menuName = "BTD6/PowersProData")]
public class PowersProData : ScriptableObject
{
	public int xpPerPurchase; //Field offset: 0x18
	public int xpPerPlace; //Field offset: 0x1C
	public float xpProMultiplier; //Field offset: 0x20
	public String[] baseAndProIds; //Field offset: 0x28

	public PowersProData() { }

	public string GetProOrBasePowerId(string powerId) { }

}

