using UnityEngine;
using UnityEditor;
using System.IO;

[InitializeOnLoad]
public class EditorVersion {
	static EditorVersion()
	{
		StreamWriter writer = new StreamWriter("Assets/Editor/EditorVersion.txt");
		writer.WriteLine(Application.unityVersion + "");
		writer.Close();
	}
}
