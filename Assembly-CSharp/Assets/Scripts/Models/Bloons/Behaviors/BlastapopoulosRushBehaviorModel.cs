namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(BlastapopoulosRushBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BlastapopoulosRushBehaviorModel : BossRushBehaviorModel
{
	internal class BlastapopoulosRushMutator : RushBehaviorMutator
	{

		public BlastapopoulosRushMutator(int baseHealth, float healthMultiplier, float speedMultiplier, int totalKills, int milestoneTierFrequency) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}


	protected BlastapopoulosRushBehaviorModel(string name, int baseHealth, float healthMultiplier, float speedMultiplier, String[] onKillActions, String[] onMilestoneActions, String[] onLivesLostActions) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual void PreSpawnBloonModelChanges(BloonModel bloonModel, int totalKills, int milestoneTierFrqeuency, float baseSpeed, int baseHealth, int baseShield, float healthMultiplier) { }

}

