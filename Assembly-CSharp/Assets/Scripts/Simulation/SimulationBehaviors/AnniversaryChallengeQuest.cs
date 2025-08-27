namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class AnniversaryChallengeQuest : RushChallengeManager
{
	internal class AniversaryQuestBloonMutator : RushBloonMutator
	{

		public AniversaryQuestBloonMutator(float speedMultiplier, float healthMultiplier, int totalKills, DestroyOnDegradeModel destroyOnDegradeModel, bool isUnique = true, int priority = 1, bool lastAppliesFirst = false, BuffIndicatorModel buffIndicator = null, int stackCount = 0, string saveId = null) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AnniversaryChallengeQuestModel subBehaviorModel; //Field offset: 0x88

	public AnniversaryChallengeQuest() { }

	protected virtual RushBloonMutator GetMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	protected virtual void OnTargetBloonLeaked(Bloon bloon) { }

	protected virtual void OnTargetDestroyEvent(RootObject obj) { }

	protected virtual void SpawnTargetBloon(bool leakedRespawn = false, int previousTargetHealth = 0) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

