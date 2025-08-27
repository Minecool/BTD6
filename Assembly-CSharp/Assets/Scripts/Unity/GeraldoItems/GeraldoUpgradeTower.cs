namespace Assets.Scripts.Unity.GeraldoItems;

public class GeraldoUpgradeTower : GeraldoItemBehavior
{
	[SerializeField]
	private int level; //Field offset: 0x10
	[SerializeField]
	private string towerId; //Field offset: 0x18

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public GeraldoUpgradeTower() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

