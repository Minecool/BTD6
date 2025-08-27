namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "EnergisingTotemAnimState", menuName = "BTD6/Behaviors/Towers/EnergisingTotemAnimState")]
public class EnergisingTotemAnimState : TowerBehavior
{
	public int animState; //Field offset: 0x30
	public Effect effect; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 97
	}

	public EnergisingTotemAnimState() { }

	public virtual TowerBehaviorModel get_Def() { }

}

