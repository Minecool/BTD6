namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Bank", menuName = "BTD6/Behaviors/Towers/Bank")]
public class Bank : TowerBehavior
{
	public float capacity; //Field offset: 0x30
	public float intrest; //Field offset: 0x34
	public float lifespan; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40
	public bool autoCollect; //Field offset: 0x48
	public PrefabReference fullDisplay; //Field offset: 0x50
	public int collectAnimation; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 223
	}

	public Bank() { }

	public virtual TowerBehaviorModel get_Def() { }

}

