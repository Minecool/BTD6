namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BananaCentralBuff", menuName = "BTD6/Behaviors/Towers/BananaCentralBuff")]
public class BananaCentralBuff : TowerBehaviorGlobalBuff
{
	public float multiplier; //Field offset: 0x40
	public string mutatorId; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 176
	}

	public BananaCentralBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

