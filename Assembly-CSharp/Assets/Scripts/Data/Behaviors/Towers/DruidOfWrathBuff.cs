namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DruidOfWrathBuff", menuName = "BTD6/Behaviors/Towers/DruidOfWrathBuff")]
public class DruidOfWrathBuff : TowerBehavior
{
	public int newPopCount; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public DruidOfWrathBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

