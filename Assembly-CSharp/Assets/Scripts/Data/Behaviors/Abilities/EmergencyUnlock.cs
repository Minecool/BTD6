namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "EmergencyUnlock", menuName = "BTD6/Behaviors/Abilities/EmergencyUnlock")]
public class EmergencyUnlock : AbilityBehavior
{
	public float swivelSpeedMultiplier; //Field offset: 0x30
	public float duration; //Field offset: 0x34
	public Sound activateSound; //Field offset: 0x38
	public PrefabReference buffDisplay; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 203
	}

	public EmergencyUnlock() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

