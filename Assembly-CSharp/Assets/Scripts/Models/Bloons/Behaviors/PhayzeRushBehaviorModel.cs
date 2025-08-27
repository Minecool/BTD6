namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PhayzeRushBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PhayzeRushBehaviorModel : BossRushBehaviorModel
{
	internal class PhayzeRushMutator : RushBehaviorMutator
	{
		public int baseArmour; //Field offset: 0x88
		public float armourMultiplier; //Field offset: 0x8C
		public float timeTriggerMultiplier; //Field offset: 0x90
		public float minimumTimerInterval; //Field offset: 0x94
		public float baseTimeTriggerInterval; //Field offset: 0x98
		public float armouredSpeedMultiplier; //Field offset: 0x9C
		public float dashSpeed; //Field offset: 0xA0
		public float dashDistance; //Field offset: 0xA4

		public PhayzeRushMutator(int baseHealth, float healthMultiplier, float speedMultiplier, int totalKills, int milestoneTierFrequency, int baseArmour, float armourMultiplier, float timeTriggerMultiplier, float baseTimeTriggerInterval, float minimumTimerInterval, float armouredSpeedMultiplier, float dashSpeed, float dashDistance) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int baseArmour; //Field offset: 0x58
	public float armourMultiplier; //Field offset: 0x5C
	public float timeTriggerBase; //Field offset: 0x60
	public float timeTriggerMultiplier; //Field offset: 0x64
	public float minTimeTriggerMultiplier; //Field offset: 0x68
	public float armouredSpeedMultiplier; //Field offset: 0x6C
	public float dashSpeed; //Field offset: 0x70
	public float dashDistance; //Field offset: 0x74

	public string Type
	{
		 get { } //Length: 44
	}

	public PhayzeRushBehaviorModel() { }

	public PhayzeRushBehaviorModel(string name, int baseHealth, float healthMultiplier, float speedMultiplier, String[] onKillActions, String[] onMilestoneActions, String[] onLivesLostActions, int baseArmour, float armourMultiplier, float timeTriggerBase, float timeTriggerMultiplier, float minTimeTriggerMultiplier, float armouredSpeedMultiplier, float dashSpeed, float dashDistance) { }

	public virtual Model Clone() { }

	public string get_Type() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual void PreSpawnBloonModelChanges(BloonModel bloonModel, int totalKills, int milestoneTierFrequency, float baseSpeed, int baseHealth, int baseShield, float healthMultiplier) { }

}

