namespace Assets.Scripts.Models;

public class PlayerCosmeticInfo
{
	public Dictionary<String, TowerCosmetics> towerCosmetics; //Field offset: 0x10
	public Dictionary<TowerSet, List`1<String>> towerSetCosmetics; //Field offset: 0x18
	public List<String> globalTowerCosmetics; //Field offset: 0x20
	public Dictionary<String, String> bloonAssetChanges; //Field offset: 0x28
	public Dictionary<String, String> bloonDecals; //Field offset: 0x30
	public Dictionary<String, String> bloonPopFX; //Field offset: 0x38
	public string globalBloonPopFX; //Field offset: 0x40
	public Dictionary<String, String> powerAssetChanges; //Field offset: 0x48

	public PlayerCosmeticInfo() { }

}

