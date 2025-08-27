namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Biohack", menuName = "BTD6/Behaviors/Abilities/Biohack")]
public class Biohack : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float damageIncrease; //Field offset: 0x34
	public int affectedCount; //Field offset: 0x38
	public string filterTowers; //Field offset: 0x40
	public Effect effect; //Field offset: 0x48
	public string buffLocsName; //Field offset: 0x50
	public string buffIconName; //Field offset: 0x58
	public TowerBehavior[] towersBehaviors; //Field offset: 0x60

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 416
	}

	public Biohack() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

