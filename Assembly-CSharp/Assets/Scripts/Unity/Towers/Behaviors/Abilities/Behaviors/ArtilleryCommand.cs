namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ArtilleryCommand : AbilityBehavior
{
	public ArtilleryCommand parent; //Field offset: 0x88
	public string givesBuff; //Field offset: 0x90
	public string expGivesBuff; //Field offset: 0x98
	public float buffDuration; //Field offset: 0xA0
	public string expBuffDuration; //Field offset: 0xA8
	public Effect otherTowerEffect; //Field offset: 0xB0
	public Effect expOtherTowerEffect; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 259
	}

	public ArtilleryCommand() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

