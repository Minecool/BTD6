namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AddBehaviorToTowerSupport", menuName = "BTD6/Behaviors/Towers/AddBehaviorToTowerSupport")]
public class AddBehaviorToTowerSupport : SupportBehavior
{
	public string mutationId; //Field offset: 0x48
	public TowerBehavior behavior; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 430
	}

	public AddBehaviorToTowerSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

