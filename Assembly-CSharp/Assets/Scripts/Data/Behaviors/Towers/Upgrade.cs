namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Upgrade", menuName = "BTD6/Behaviors/Towers/Upgrade")]
public class Upgrade : EntityBehavior<UpgradeModel>
{
	public int path; //Field offset: 0x28
	public int tier; //Field offset: 0x2C
	public int cost; //Field offset: 0x30
	public int xpCost; //Field offset: 0x34
	public int locked; //Field offset: 0x38
	public string confirmation; //Field offset: 0x40
	public SpriteReference icon; //Field offset: 0x48
	public string localizedNameOverride; //Field offset: 0x50
	public bool isParagon; //Field offset: 0x58

	public virtual UpgradeModel Def
	{
		 get { } //Length: 213
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public Upgrade() { }

	public virtual UpgradeModel get_Def() { }

	public virtual Model get_Model() { }

}

