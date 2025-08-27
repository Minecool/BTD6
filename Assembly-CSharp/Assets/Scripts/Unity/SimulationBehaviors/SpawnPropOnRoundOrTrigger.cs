namespace Assets.Scripts.Unity.SimulationBehaviors;

public class SpawnPropOnRoundOrTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x18
	public String[] prePlacePropIndexs; //Field offset: 0x20
	public Int32[] round; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 128
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnPropOnRoundOrTrigger() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

