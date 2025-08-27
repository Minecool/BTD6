//Type is in global namespace

public class PowerImageLoader : MonoBehaviour
{
	public Material grayscaleMaterial; //Field offset: 0x20
	public Image image; //Field offset: 0x28
	public Image bg; //Field offset: 0x30
	private PowerModel powerModel; //Field offset: 0x38

	public PowerImageLoader() { }

	public void Load(string powerId) { }

}

