namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class EmergencyUnlock : AbilityBehavior
{
	public EmergencyUnlock parent; //Field offset: 0x88
	public float swivelSpeedMultiplier; //Field offset: 0x90
	public string expSwivelSpeedMultiplier; //Field offset: 0x98
	public float duration; //Field offset: 0xA0
	public string expDuration; //Field offset: 0xA8
	public AudioClip activateSound; //Field offset: 0xB0
	public AudioClip expActivateSound; //Field offset: 0xB8
	public GameObject buffDisplay; //Field offset: 0xC0
	public GameObject expBuffDisplay; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 399
	}

	public EmergencyUnlock() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

