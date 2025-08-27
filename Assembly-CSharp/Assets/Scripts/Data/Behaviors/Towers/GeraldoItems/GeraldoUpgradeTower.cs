namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "GeraldoUpgradeTower", menuName = "BTD6/Behaviors/Towers/GeraldoItems/GeraldoUpgradeTower")]
public class GeraldoUpgradeTower : GeraldoItemBehavior
{
	public int level; //Field offset: 0x28
	public string towerId; //Field offset: 0x30

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public GeraldoUpgradeTower() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

