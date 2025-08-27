namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PerRoundCashBonusTower", menuName = "BTD6/Behaviors/Towers/PerRoundCashBonusTower")]
public class PerRoundCashBonusTower : TowerBehavior
{
	public float cashPerRound; //Field offset: 0x30
	public float cashRoundBonusMultiplier; //Field offset: 0x34
	public float lifespan; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40
	public bool distributeCash; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 193
	}

	public PerRoundCashBonusTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

