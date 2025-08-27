namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SubCommanderSupport", menuName = "BTD6/Behaviors/Towers/SubCommanderSupport")]
public class SubCommanderSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public int pierceIncrease; //Field offset: 0x4C
	public int damageIncrease; //Field offset: 0x50
	public float damageScale; //Field offset: 0x54
	public string filterTower; //Field offset: 0x58
	public bool appliesToOwningTower; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 752
	}

	public SubCommanderSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

