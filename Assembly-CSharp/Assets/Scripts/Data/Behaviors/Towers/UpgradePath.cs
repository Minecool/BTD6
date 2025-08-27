namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "UpgradePath", menuName = "BTD6/Behaviors/Towers/UpgradePath")]
public class UpgradePath : Behavior<UpgradePathModel>
{
	public string upgrade; //Field offset: 0x28
	public string tower; //Field offset: 0x30

	public virtual UpgradePathModel Def
	{
		 get { } //Length: 105
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public UpgradePath() { }

	public virtual UpgradePathModel get_Def() { }

	public virtual Model get_Model() { }

}

