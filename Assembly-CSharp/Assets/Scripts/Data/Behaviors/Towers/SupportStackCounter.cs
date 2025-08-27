namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SupportStackCounter", menuName = "BTD6/Behaviors/Towers/SupportStackCounter")]
public class SupportStackCounter : SupportBehavior
{
	public string mutatorId; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 240
	}

	public SupportStackCounter() { }

	public virtual TowerBehaviorModel get_Def() { }

}

