namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(BossRushBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BossRushBehaviorModel : BloonBehaviorModel
{
	internal class RushBehaviorMutator : BehaviorMutator
	{
		public int baseHealth; //Field offset: 0x70
		public float healthMultiplier; //Field offset: 0x74
		public float speedMultiplier; //Field offset: 0x78
		public int totalKills; //Field offset: 0x7C
		public int milestoneTierFrequency; //Field offset: 0x80

		public RushBehaviorMutator(int baseHealth, float healthMultiplier, float speedMultiplier, int totalKills, int milestoneTierFrequency) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int baseHealth; //Field offset: 0x30
	public float healthMultiplier; //Field offset: 0x34
	public float speedMultiplier; //Field offset: 0x38
	public String[] onKillActions; //Field offset: 0x40
	public String[] onMilestoneActions; //Field offset: 0x48
	public String[] onLivesLostActions; //Field offset: 0x50

	protected BossRushBehaviorModel(string name, int baseHealth, float healthMultiplier, float speedMultiplier, String[] onKillActions, String[] onMilestoneActions, String[] onLivesLostActions) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public override void PreSpawnBloonModelChanges(BloonModel bloonModel, int totalKills, int milestoneTierFrqeuency, float baseSpeed, int baseHealth, int baseShield, float healthMultiplier) { }

}

