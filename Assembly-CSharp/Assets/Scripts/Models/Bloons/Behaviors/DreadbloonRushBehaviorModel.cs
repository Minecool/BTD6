namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DreadbloonRushBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DreadbloonRushBehaviorModel : BossRushBehaviorModel
{
	internal class DreadbloonRushMutator : RushBehaviorMutator
	{
		public int baseArmour; //Field offset: 0x88
		public float armourMultiplier; //Field offset: 0x8C
		public float armouredSpeedMultiplier; //Field offset: 0x90
		public int damageReduction; //Field offset: 0x94

		public DreadbloonRushMutator(int baseHealth, float healthMultiplier, float speedMultiplier, int totalKills, int milestoneTierFrequency, int baseArmour, float armourMultiplier, float armouredSpeedMultiplier, int damageReduction) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int baseArmour; //Field offset: 0x58
	public float armourMultiplier; //Field offset: 0x5C
	public int rockBloonBaseHealth; //Field offset: 0x60
	public float rockBloonHealthMultiplier; //Field offset: 0x64
	public int rockBloonAmount; //Field offset: 0x68
	public float rockBloonSpawnDelay; //Field offset: 0x6C
	public float armouredSpeedMultiplier; //Field offset: 0x70
	public int damageReduction; //Field offset: 0x74

	protected DreadbloonRushBehaviorModel(string name, int baseHealth, float healthMultiplier, float speedMultiplier, String[] onKillActions, String[] onMilestoneActions, String[] onLivesLostActions, int baseArmour, float armourMultiplier, int rockBloonBaseHealth, float rockBloonHealthMultiplier, int rockBloonAmount, float rockBloonSpawnDelay, float armouredSpeedMultiplier, int damageReduction) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual void PreSpawnBloonModelChanges(BloonModel bloonModel, int totalKills, int milestoneTierFrequency, float baseSpeed, int baseHealth, int baseShield, float healthMultiplier) { }

}

