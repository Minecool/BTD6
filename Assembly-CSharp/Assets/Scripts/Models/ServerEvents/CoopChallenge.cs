namespace Assets.Scripts.Models.ServerEvents;

public class CoopChallenge : RemoteDataServerEvent<NewsPanelBackgroundMetadata, DailyChallengeModel>
{

	public CoopChallenge() { }

	protected virtual DailyChallengeModel ValidateData(DailyChallengeModel dcm) { }

}

