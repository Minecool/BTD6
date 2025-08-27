namespace Assets.Scripts.Data.Quests.InGame;

public class DialogueInGameOnRound : DialogueDataTaskInGame
{
	public int round; //Field offset: 0x28
	public bool pauseAutoPlay; //Field offset: 0x2C

	public DialogueInGameOnRound() { }

	public virtual void Bind(bool isLoadedSave) { }

	public void OnRoundEnd(int roundIndex) { }

	public void OnSimLoaded() { }

	private void PerformAction() { }

	public virtual void Unbind() { }

}

