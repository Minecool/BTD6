namespace Assets.Scripts.Data.Legends;

public abstract class RogueXpShopMod
{

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	protected RogueXpShopMod() { }

	public override void ApplyDCMEffect(int level, DailyChallengeModel dcm) { }

	public override void ApplyIngameEffect(int level, GameModel moddedGameModel) { }

	public override void ApplyMapEffect(int level) { }

	public override void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	protected string BuildBuffTextPercentageString(float buffAmount, int level) { }

	protected string BuildBuffTextString(int buffAmount, int level) { }

	private LocalizationManager get_Locs() { }

	public override int GetAdditionalStartingArtifactPower(int level) { }

	public override string GetBuffText(int level) { }

	public override string GetMutatorModName() { }

}

