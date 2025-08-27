namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Biohack : AbilityBehavior
{
	public Biohack parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float damageIncrease; //Field offset: 0xA0
	public string expDamageIncrease; //Field offset: 0xA8
	public int affectedCount; //Field offset: 0xB0
	public string expAffectedCount; //Field offset: 0xB8
	public string filterTowers; //Field offset: 0xC0
	public string expFilterTowers; //Field offset: 0xC8
	public Effect effect; //Field offset: 0xD0
	public Effect expEffect; //Field offset: 0xD8
	public string buffLocsName; //Field offset: 0xE0
	public string expBuffLocsName; //Field offset: 0xE8
	public string buffIconName; //Field offset: 0xF0
	public string expBuffIconName; //Field offset: 0xF8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 470
	}

	public Biohack() { }

	public TowerBehaviorModel[] GatherBehaviors() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

