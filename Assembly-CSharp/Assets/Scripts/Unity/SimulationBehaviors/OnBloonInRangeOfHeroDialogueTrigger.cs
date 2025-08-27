namespace Assets.Scripts.Unity.SimulationBehaviors;

public class OnBloonInRangeOfHeroDialogueTrigger : SimulationBehavior
{
	[TowerType]
	public string hero; //Field offset: 0x18
	[BloonType]
	public string bloonType; //Field offset: 0x20
	public DialogueDataModel dialogue; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 128
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public OnBloonInRangeOfHeroDialogueTrigger() { }

	public OnBloonInRangeOfHeroDialogueTrigger(string hero, string bloonType, DialogueDataModel dialogue) { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

