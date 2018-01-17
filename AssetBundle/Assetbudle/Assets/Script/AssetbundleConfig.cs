using UnityEngine;
using System.Collections;

public class AssetbundleConfig : MonoBehaviour {



	//打包路径
		public static string ASSETBUNDLE_PATH = Application.dataPath + "/StreamingAssets/";

		//资源地址
		public static string APPLICATION_PATH = Application.dataPath + "/";

		//工程地址
		public static string PROJECT_PATH = APPLICATION_PATH.Substring(0, APPLICATION_PATH.Length - 7);

		//AssetBundle存放的文件夹名
		public static string ASSETBUNDLE_FILENAM = "AssetBundle";

		//AssetBundle打包的后缀名
		public static string SUFFIX = ".unity3d";



	
	// Update is called once per frame
	void Update () {
	
	}
}
