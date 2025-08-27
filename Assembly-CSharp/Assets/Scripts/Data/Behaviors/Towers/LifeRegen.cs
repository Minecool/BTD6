namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "LifeRegen", menuName = "BTD6/Behaviors/Towers/LifeRegen")]
public class LifeRegen : TowerBehavior
{
	public float regenAmount; //Field offset: 0x30
	public float overRegenAmount; //Field offset: 0x34
	public float lifespan; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 175
	}

	public LifeRegen() { }

	public virtual TowerBehaviorModel get_Def() { }

}

