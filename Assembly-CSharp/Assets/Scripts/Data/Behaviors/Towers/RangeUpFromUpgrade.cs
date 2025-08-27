namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RangeUpFromUpgrade", menuName = "BTD6/Behaviors/Towers/RangeUpFromUpgrade")]
public class RangeUpFromUpgrade : TowerBehavior
{
	public float rangePerUpgrade; //Field offset: 0x30
	public float upgradeTier; //Field offset: 0x34
	public float upgradePath; //Field offset: 0x38
	public string towerBaseId; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 187
	}

	public RangeUpFromUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

