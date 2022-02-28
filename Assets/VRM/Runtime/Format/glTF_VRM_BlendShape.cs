using System;
using System.Collections.Generic;
using UniGLTF;
using UniJSON;


namespace VRM
{
    [Serializable]
    [JsonSchema(Title = "vrm.blendshape.materialbind")]
    public class glTF_VRM_MaterialValueBind
    {
        public string materialName;
        public string propertyName;
        public float[] targetValue;
    }

    [Serializable]
    [JsonSchema(Title = "vrm.blendshape.bind")]
    public class glTF_VRM_BlendShapeBind
    {
        [JsonSchema(Required = true, Minimum = 0)]
        public int mesh = -1;

        [JsonSchema(Required = true, Minimum = 0)]
        public int index = -1;

        [JsonSchema(Required = true, Minimum = 0, Maximum = 100, Description = @"SkinnedMeshRenderer.SetBlendShapeWeight")]
        public float weight = 0;
    }

    public enum BlendShapePreset
    {
        Unknown,

        Neutral,
        //visemes, augmented to the list to remove duplicates
        sil,
        PP,
        FF,
        TH,
        DD,
        kk,
        CH,
        SS,
        nn,
        RR,
        A, //still needed because it's used by vseeface and others
        aa,
        E, //ditto here
        I, //here
        O, //here
        U, //and here. Don't change these.

        Blink,

        // 喜怒哀楽
        Joy,
        Angry,
        Smug,
        Cute,
        Sorrow,
        Fun,

        // LookAt
        LookUp,
        LookDown,
        LookLeft,
        LookRight,

        Blink_L,
        Blink_R,
        
        //Arkit blank presets
        BrowInnerUp,
        BrowDownLeft,
        BrowDownRight,
        BrowOuterUpLeft,
        BrowOuterUpRight,
        EyeLookUpLeft,
        EyeLookUpRight,
        EyeLookDownLeft,
        EyeLookDownRight,
        EyeLookInLeft,
        EyeLookInRight,
        EyeLookOutLeft,
        EyeLookOutRight,
        EyeBlinkLeft,
        EyeBlinkRight,
        EyeSquintRight,
        EyeSquintLeft,
        EyeWideLeft,
        EyeWideRight,
        CheekPuff,
        CheekSquintLeft,
        CheekSquintRight,
        NoseSneerLeft,
        NoseSneerRight,
        JawOpen,
        JawForward,
        JawLeft,
        JawRight,
        MouthFunnel,
        MouthPucker,
        MouthLeft,
        MouthRight,
        MouthRollUpper,
        MouthRollLower,
        MouthShrugUpper,
        MouthShrugLower,
        MouthClose,
        MouthSmileLeft,
        MouthSmileRight,
        MouthFrownLeft,
        MouthFrownRight,
        MouthDimpleLeft,
        MouthDimpleRight,
        MouthUpperUpLeft,
        MouthUpperUpRight,
        MouthLowerDownLeft,
        MouthLowerDownRight,
        MouthPressLeft,
        MouthPressRight,
        MouthStretchLeft,
        MouthStretchRight,
        TongueOut,
    }

    [Serializable]
    [JsonSchema(Title = "vrm.blendshape.group", Description = "BlendShapeClip of UniVRM")]
    public class glTF_VRM_BlendShapeGroup
    {
        [JsonSchema(Description = "Expression name")]
        public string name;

        [JsonSchema(Description = "Predefined Expression name", EnumValues = new object[] {
            "unknown",
            "neutral",
            "sil",
            "PP",
            "FF",
            "TH",
            "DD",
            "kk",
            "CH",
            "SS",
            "nn",
            "RR",
            "A",
            "aa",
            "E",
            "I",
            "O",
            "U",
            "blink",
            "joy",
            "angry",
            "smug",
            "cute",
            "sorrow",
            "fun",
            "lookup",
            "lookdown",
            "lookleft",
            "lookright",
            "blink_l",
            "blink_r",
            "browinnerup",
            "browdownleft",
            "browdownright",
            "browouterupleft",
            "browouterupright",
            "eyelookupleft",
            "eyelookupright",
            "eyelookdownleft",
            "eyelookdownright",
            "eyelookinleft",
            "eyelookinright",
            "eyelookoutleft",
            "eyelookoutright",
            "eyeblinkleft",
            "eyeblinkright",
            "eyesquintright",
            "eyesquintleft",
            "eyewideleft",
            "eyewideright",
            "cheekpuff",
            "cheeksquintleft",
            "cheeksquintright",
            "nosesneerleft",
            "nosesneerright",
            "jawopen",
            "jawforward",
            "jawleft",
            "jawright",
            "mouthfunnel",
            "mouthpucker",
            "mouthleft",
            "mouthright",
            "mouthrollupper",
            "mouthrolllower",
            "mouthshrugupper",
            "mouthshruglower",
            "mouthclose",
            "mouthsmileleft",
            "mouthsmileright",
            "mouthfrownleft",
            "mouthfrownright",
            "mouthdimpleleft",
            "mouthdimpleright",
            "mouthupperupleft",
            "mouthupperupright",
            "mouthlowerdownleft",
            "mouthlowerdownright",
            "mouthpressleft",
            "mouthpressright",
            "mouthstretchleft",
            "mouthstretchright",
            "tongueout",
        }, EnumSerializationType = EnumSerializationType.AsString)]
        public string presetName;

        [JsonSchema(Description = "Low level blendshape references. ")]
        public List<glTF_VRM_BlendShapeBind> binds = new List<glTF_VRM_BlendShapeBind>();

        [JsonSchema(Description = "Material animation references.")]
        public List<glTF_VRM_MaterialValueBind> materialValues = new List<glTF_VRM_MaterialValueBind>();

        [JsonSchema(Description = "0 or 1. Do not allow an intermediate value. Value should rounded")]
        public bool isBinary;
    }

    [Serializable]
    [JsonSchema(Title = "vrm.blendshape", Description = "BlendShapeAvatar of UniVRM")]
    public class glTF_VRM_BlendShapeMaster
    {
        public List<glTF_VRM_BlendShapeGroup> blendShapeGroups = new List<glTF_VRM_BlendShapeGroup>();
    }
}
