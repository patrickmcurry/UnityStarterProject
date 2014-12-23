using UnityEngine;
using UnityEditor;
using System.IO;

[InitializeOnLoad]
public class EditorVersion {
	static EditorVersion()
	{
		Directory.CreateDirectory("Assets/Resources");
		StreamWriter writer = new StreamWriter("Assets/Resources/EditorVersion.txt");
		writer.WriteLine(Application.unityVersion + "");
		writer.Close();
	}
}

