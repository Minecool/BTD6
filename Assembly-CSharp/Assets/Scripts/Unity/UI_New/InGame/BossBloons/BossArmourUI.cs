namespace Assets.Scripts.Unity.UI_New.InGame.BossBloons;

public class BossArmourUI : MonoBehaviour
{
	public string bossID; //Field offset: 0x20
	public GameObject container; //Field offset: 0x28
	public Image img; //Field offset: 0x30
	public GameObject edge; //Field offset: 0x38
	public int edgeAnimationFrameCount; //Field offset: 0x40

	public BossArmourUI() { }

}

