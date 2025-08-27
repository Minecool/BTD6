namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SoulbindManager", menuName = "BTD6/Behaviors/Towers/SoulbindManager")]
public class SoulbindManager : TowerBehavior
{
	public Effect effectOnTransitionBack; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public SoulbindManager() { }

	public virtual TowerBehaviorModel get_Def() { }

}

