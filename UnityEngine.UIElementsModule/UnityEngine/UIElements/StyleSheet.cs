namespace UnityEngine.UIElements;

[HelpURL("UIE-USS")]
public class StyleSheet : ScriptableObject
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	public struct ImportStruct
	{
		public StyleSheet styleSheet; //Field offset: 0x0
		public String[] mediaQueries; //Field offset: 0x8

	}

	public enum OrderedSelectorType
	{
		None = -1,
		Name = 0,
		Type = 1,
		Class = 2,
		Length = 3,
	}

	private static string kCustomPropertyMarker; //Field offset: 0x0
	[SerializeField]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; //Field offset: 0x19
	[SerializeField]
	private StyleRule[] m_Rules; //Field offset: 0x20
	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors; //Field offset: 0x28
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal Single[] floats; //Field offset: 0x30
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal Dimension[] dimensions; //Field offset: 0x38
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal Color[] colors; //Field offset: 0x40
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal String[] strings; //Field offset: 0x48
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal Object[] assets; //Field offset: 0x50
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal ImportStruct[] imports; //Field offset: 0x58
	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; //Field offset: 0x60
	[SerializeField]
	private int m_ContentHash; //Field offset: 0x68
	[SerializeField]
	internal ScalableImage[] scalableImages; //Field offset: 0x70
	internal Dictionary<String, StyleComplexSelector>[] tables; //Field offset: 0x78
	internal int nonEmptyTablesMask; //Field offset: 0x80
	internal StyleComplexSelector firstRootSelector; //Field offset: 0x88
	internal StyleComplexSelector firstWildCardSelector; //Field offset: 0x90
	private bool m_IsDefaultStyleSheet; //Field offset: 0x98

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal StyleComplexSelector[] complexSelectors
	{
		internal get { } //Length: 7
		internal set { } //Length: 11
	}

	public int contentHash
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	internal List<StyleSheet> flattenedRecursiveImports
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
		internal get { } //Length: 7
	}

	public internal bool importedWithErrors
	{
		 get { } //Length: 7
		internal set { } //Length: 4
	}

	public internal bool importedWithWarnings
	{
		 get { } //Length: 7
		internal set { } //Length: 4
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal bool isDefaultStyleSheet
	{
		internal get { } //Length: 10
		internal set { } //Length: 271
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal StyleRule[] rules
	{
		internal get { } //Length: 159
		internal set { } //Length: 11
	}

	private static StyleSheet() { }

	public StyleSheet() { }

	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	private static bool CustomStartsWith(string originalString, string pattern) { }

	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	internal void FlattenImportedStyleSheetsRecursive() { }

	internal StyleComplexSelector[] get_complexSelectors() { }

	public int get_contentHash() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	public bool get_importedWithErrors() { }

	public bool get_importedWithWarnings() { }

	internal bool get_isDefaultStyleSheet() { }

	internal StyleRule[] get_rules() { }

	internal override void OnEnable() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal object ReadAssetReference(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal Color ReadColor(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal string ReadEnum(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal float ReadFloat(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal string ReadFunctionName(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal string ReadResourcePath(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal string ReadString(StyleValueHandle handle) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal string ReadVariable(StyleValueHandle handle) { }

	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	public void set_contentHash(int value) { }

	internal void set_importedWithErrors(bool value) { }

	internal void set_importedWithWarnings(bool value) { }

	internal void set_isDefaultStyleSheet(bool value) { }

	internal void set_rules(StyleRule[] value) { }

	private void SetupReferences() { }

	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }

	internal bool TryReadAssetReference(StyleValueHandle handle, out object value) { }

	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

}

