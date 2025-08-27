//Type is in global namespace

public class FlatFileCodeGen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Assembly, Boolean> <>9__14_0; //Field offset: 0x8
		public static Func<Assembly, IEnumerable`1<Type>> <>9__14_1; //Field offset: 0x10
		public static Func<Type, Boolean> <>9__14_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <WriteClass>b__14_0(Assembly a) { }

		internal IEnumerable<Type> <WriteClass>b__14_1(Assembly s) { }

		internal bool <WriteClass>b__14_2(Type p) { }

	}

	private BindingFlags bindFlags; //Field offset: 0x10
	private Dictionary<Type, List`1<Object>> dataTypes; //Field offset: 0x18
	private Dictionary<Type, HashSet`1<Object>> dataTypesMap; //Field offset: 0x20
	public Dictionary<Object, Int32> objMap; //Field offset: 0x28
	private StreamWriter sw; //Field offset: 0x30
	private BinaryWriter br; //Field offset: 0x38
	private HashSet<Object> foundDataTypes; //Field offset: 0x40
	private string tab; //Field offset: 0x48

	public FlatFileCodeGen() { }

	public static IGameModelLoader CreateGameModelLoader() { }

	private void FindAllDataTypes(object obj) { }

	private string FixFullName(string className) { }

	private string FormatType(Type t) { }

	public void Generate(object src, string binPath, string loaderPath) { }

	public Byte[] Generate(object src) { }

	protected string GetReadPrimative(Type fieldType) { }

	private string GetVarName(Type t) { }

	public bool HasDefaultConstructor(Type t) { }

	private void Indent() { }

	private bool IsHiddenField(FieldInfo field) { }

	private bool IsLinkLoadField(FieldInfo field, Type classType) { }

	protected bool IsPrimative(Type fieldType) { }

	private bool IsSerialisedField(FieldInfo field) { }

	protected bool IsStruct(Type fieldType) { }

	protected string ReadBinaryStruct(Type fieldType) { }

	private void SetObjectMap(object value) { }

	private void SetObjMap() { }

	private void Step1() { }

	private void Step2() { }

	private void Step3() { }

	private void Step4() { }

	private void UndoIndent() { }

	private void WriteBinaryObjectLink(Type itemType) { }

	private void WriteBinaryObjectLink(Type itemType, List<Object> items) { }

	private void WriteBinaryPrimative(Type fieldType, object value) { }

	protected void WriteBinaryStruct(Type fieldType, object value) { }

	private void WriteClass(object src) { }

	private void WriteCreateArray() { }

	private void WriteCreateDictionary() { }

	private void WriteCreateEnumArray(Type t, Type itemT) { }

	private void WriteCreateList() { }

	private void WriteCreatePrimativeArray(Type t, string typeName) { }

	private void WriteCreatePrimativeEnumList(Type t, Type elemType) { }

	private void WriteCreatePrimativeList(Type t, string typeName) { }

	private void WriteCreatePrimativeStringDictionary(Type t, Type valueType, string typeName) { }

	private void WriteCreateRecords() { }

	private void WriteCreateStructArray(Type t, Type elementType) { }

	private void WriteGet(object src) { }

	private void WriteLine(string line = "") { }

	private void WriteLinkArray() { }

	private void WriteLinkDictionary() { }

	private void WriteLinkList() { }

	private void WriteLinkLoadObj(Type itemType) { }

	private void WriteLinkLoadReflection(Type itemType) { }

	private void WriteLinkModelDictionary() { }

	private void WriteLoadPrimativeArray(Type itemType) { }

	private void WriteSetFieldsMethod(Type type) { }

}

