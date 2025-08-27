namespace Assets.Scripts.Unity.Map;

public class Splitter : MonoBehaviour
{
	public Path[] paths; //Field offset: 0x20
	private SplitterModel def; //Field offset: 0x28
	public Path overrideBossPath; //Field offset: 0x30

	public override SplitterModel Def
	{
		 get { } //Length: 505
	}

	public Splitter() { }

	public override SplitterModel get_Def() { }

}

