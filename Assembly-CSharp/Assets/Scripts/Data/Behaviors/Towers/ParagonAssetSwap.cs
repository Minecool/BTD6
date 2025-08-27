namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ParagonAssetSwap", menuName = "BTD6/Behaviors/Towers/ParagonAssetSwap")]
public class ParagonAssetSwap : TowerBehavior
{
	public PrefabReference displayToSwap; //Field offset: 0x30
	public PrefabReference newDisplay; //Field offset: 0x38
	public int degree; //Field offset: 0x40
	public bool applyToAllAbove; //Field offset: 0x44

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public ParagonAssetSwap() { }

	public virtual TowerBehaviorModel get_Def() { }

}

