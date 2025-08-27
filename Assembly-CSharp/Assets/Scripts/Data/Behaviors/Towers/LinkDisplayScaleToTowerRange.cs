namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "LinkDisplayScaleToTowerRange", menuName = "BTD6/Behaviors/Towers/LinkDisplayScaleToTowerRange")]
public class LinkDisplayScaleToTowerRange : TowerBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public float displayRadius; //Field offset: 0x38
	public Attack hideIfAttackPaused; //Field offset: 0x40
	public Tower tower; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 281
	}

	public LinkDisplayScaleToTowerRange() { }

	public virtual TowerBehaviorModel get_Def() { }

}

