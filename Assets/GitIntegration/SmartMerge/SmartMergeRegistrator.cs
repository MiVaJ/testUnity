}

        [MenuItem("Tools/Git/SmartMerge unregistration")]
        static void SmartMergeUnRegister()
        {
            Utils.ExecuteGitWithParams("config --remove-section merge.unityyamlmerge");
            Debug.Log($"Succesfuly unregistered UnityYAMLMerge");
        }

        //Unity calls the static constructor when the engine opens
        static SmartMergeRegistrator()
        {
            var instaledVersionKey = EditorPrefs.GetString(SmartMergeRegistratorEditorPrefsKey);
            if (instaledVersionKey != VersionKey)
                SmartMergeRegister();
        }
    }
}
#endif