namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MonkeyCity", menuName = "BTD6/Behaviors/Towers/MonkeyCity")]
public class MonkeyCity : TowerBehavior
{
	public int roundsTillMultiplier; //Field offset: 0x30
	public string towerId; //Field offset: 0x38
	public float multiplier; //Field offset: 0x40
	public string mutatorId; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public MonkeyCity() { }

	public virtual TowerBehaviorModel get_Def() { }

}

