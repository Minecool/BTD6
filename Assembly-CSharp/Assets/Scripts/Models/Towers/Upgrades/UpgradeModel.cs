namespace Assets.Scripts.Models.Towers.Upgrades;

public class UpgradeModel : Model
{
	public int cost; //Field offset: 0x30
	public int xpCost; //Field offset: 0x34
	public SpriteReference icon; //Field offset: 0x38
	public int path; //Field offset: 0x40
	public int tier; //Field offset: 0x44
	public int locked; //Field offset: 0x48
	public string confirmation; //Field offset: 0x50
	public string localizedNameOverride; //Field offset: 0x58

	public bool IsParagon
	{
		 get { } //Length: 8
	}

	public string LocsKey
	{
		 get { } //Length: 49
	}

	public UpgradeModel(string name, int cost, int xpCost, SpriteReference icon, int path, int tier, int locked, string confirmation, string localizedNameOverride) { }

	public virtual Model Clone() { }

	public bool get_IsParagon() { }

	public string get_LocsKey() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

