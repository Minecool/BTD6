namespace Assets.Scripts.Data.Gameplay;

[CreateAssetMenu(menuName = "BTD6/Talking Head Hints")]
public class TalkingHeadHints : ScriptableObject
{
	public TalkingHeadHint[] hints; //Field offset: 0x18

	public TalkingHeadHints() { }

}

