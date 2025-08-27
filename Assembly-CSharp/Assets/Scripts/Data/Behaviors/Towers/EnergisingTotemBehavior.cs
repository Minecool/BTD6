namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "EnergisingTotemBehavior", menuName = "BTD6/Behaviors/Towers/EnergisingTotemBehavior")]
public class EnergisingTotemBehavior : TowerBehavior
{
	public int rounds; //Field offset: 0x30
	public int monkeyMonkeyCost; //Field offset: 0x34
	public Int32[] animStates; //Field offset: 0x38
	public EnergisingTotemAnimState[] effects; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 180
	}

	public EnergisingTotemBehavior() { }

	public virtual TowerBehaviorModel get_Def() { }

}

