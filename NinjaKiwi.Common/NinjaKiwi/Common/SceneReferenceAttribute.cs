namespace NinjaKiwi.Common;

[AttributeUsage(AttributeTargets::Field (256))]
public class SceneReferenceAttribute : PropertyAttribute
{
	public bool asPopup; //Field offset: 0x18
	public String[] directoryPaths; //Field offset: 0x20

	public SceneReferenceAttribute() { }

	public SceneReferenceAttribute(string singleDirectory) { }

	public SceneReferenceAttribute(String[] directoryArray) { }

}

