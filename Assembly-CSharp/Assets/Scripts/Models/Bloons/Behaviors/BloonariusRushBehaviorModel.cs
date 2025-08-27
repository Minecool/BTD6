namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(BloonariusRushBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloonariusRushBehaviorModel : BossRushBehaviorModel
{
	internal class BloonariusRushMutator : RushBehaviorMutator
	{
		public List<String> strongSpawns; //Field offset: 0x88
		public List<String> weakSpawns; //Field offset: 0x90
		public List<String> bleedSpawns; //Field offset: 0x98
		public int strongAmount; //Field offset: 0xA0
		public int weakAmount; //Field offset: 0xA4
		public int bleedAmount; //Field offset: 0xA8
		public float bleedFrequency; //Field offset: 0xAC

		public BloonariusRushMutator(int baseHealth, float healthMultiplier, float speedMultiplier, int totalKills, int milestoneTierFrequency, List<String> strongSpawns, List<String> weakSpawns, List<String> bleedSpawns, int strongAmount, int weakAmount, int bleedAmount, float bleedFrequency) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public List<String> strongSpawns; //Field offset: 0x58
	public int strongAmount; //Field offset: 0x60
	public List<String> weakSpawns; //Field offset: 0x68
	public int weakAmount; //Field offset: 0x70
	public List<String> bleedSpawns; //Field offset: 0x78
	public int bleedAmount; //Field offset: 0x80
	public float bleedFrequency; //Field offset: 0x84

	protected BloonariusRushBehaviorModel(string name, int baseHealth, float healthMultiplier, float speedMultiplier, String[] onKillActions, String[] onMilestoneActions, String[] onLivesLostActions, List<String> strongSpawns, List<String> weakSpawns, List<String> bleedSpawns, int strongAmount, int weakAmount, int bleedAmount, float bleedFrequency) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual void PreSpawnBloonModelChanges(BloonModel bloonModel, int totalKills, int milestoneTierFrequency, float baseSpeed, int baseHealth, int baseShield, float healthMultiplier) { }

}

