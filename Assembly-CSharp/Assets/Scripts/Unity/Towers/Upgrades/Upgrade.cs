namespace Assets.Scripts.Unity.Towers.Upgrades;

public class Upgrade : CascadingItem
{
	public int path; //Field offset: 0x80
	public int tier; //Field offset: 0x84
	public int cost; //Field offset: 0x88
	public int xpCost; //Field offset: 0x8C
	public int locked; //Field offset: 0x90
	public string confirmation; //Field offset: 0x98
	public GameObject icon; //Field offset: 0xA0
	public string localizedNameOverride; //Field offset: 0xA8
	public string isParagon; //Field offset: 0xB0
	private UpgradeModel def; //Field offset: 0xB8
	public Tower parentProxy; //Field offset: 0xC0

	public UpgradeModel Def
	{
		 get { } //Length: 412
	}

	public bool IsParagon
	{
		 get { } //Length: 14
	}

	public virtual Model Model
	{
		 get { } //Length: 400
	}

	public Upgrade() { }

	public UpgradeModel get_Def() { }

	public bool get_IsParagon() { }

	public virtual Model get_Model() { }

	public void UpdateExp() { }

}

