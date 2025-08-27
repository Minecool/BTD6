namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CentralMarketBuff", menuName = "BTD6/Behaviors/Towers/CentralMarketBuff")]
public class CentralMarketBuff : TowerBehaviorBuff
{
	public float multiplier; //Field offset: 0x38
	public string mutatorId; //Field offset: 0x40
	public int maxStackCount; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 175
	}

	public CentralMarketBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

