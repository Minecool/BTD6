namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class UCAV : AbilityBehavior
{
	public UCAV parent; //Field offset: 0x88
	public float duration; //Field offset: 0x90
	public string expDuration; //Field offset: 0x98
	public Tower uavTower; //Field offset: 0xA0
	public Tower expUavTower; //Field offset: 0xA8
	public Tower ucavTower; //Field offset: 0xB0
	public Tower expUcavTower; //Field offset: 0xB8
	public Effect effectAtTowerEnd; //Field offset: 0xC0
	public Effect expEffectAtTowerEnd; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 327
	}

	public UCAV() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

