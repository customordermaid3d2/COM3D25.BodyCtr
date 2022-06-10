using LillyUtill.MyMaidActive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM3D2.BodyCtr
{
    public static class MPNUtill
    {
        public static Maid maid;

        //--------------------
        internal static int akey;

        public static int acnt;

        public static MPN[] ampns;
        public static string[] anames;

        public static float[] amins;
        public static float[] amaxs;
        public static float[] anows;

        public static bool[] aisCrcParts;
        public static List<SubProp>[] alistSubProp;
        public static MaidProp[] aMaidProp;

        //--------------------
        public static string[] dKeys;

        public static Dictionary<string, int> dcnt;

        public static Dictionary<string, MPN[]> dmpns; // base
        public static Dictionary<string, string[]> dnames;

        public static Dictionary<string, float[]> dmins;
        public static Dictionary<string, float[]> dmaxs;
        public static Dictionary<string, float[]> dnows;

        public static Dictionary<string, bool[]> disCrcParts;
        public static Dictionary<string, List<SubProp>[]> dlistSubProp;
        public static Dictionary<string, MaidProp[]> dMaidProp;
        public static bool maidOn;


        //--------------------

        public static void init()
        {
            dcnt = new Dictionary<string, int>();

            dmpns = new Dictionary<string, MPN[]>();
            dnames = new Dictionary<string, string[]>();

            dmins = new Dictionary<string, float[]>();
            dmaxs = new Dictionary<string, float[]>();
            dnows = new Dictionary<string, float[]>();

            disCrcParts = new Dictionary<string, bool[]>();
            dlistSubProp = new Dictionary<string, List<SubProp>[]>();
            dMaidProp = new Dictionary<string, MaidProp[]>();

            dmpnsSetup();
            dKeys = dmpns.Keys.ToArray();
            foreach (var item in dKeys)
            {
                int c = dcnt[item] = dmpns[item].Length;

                dnames[item] = new string[c];

                dmins[item] = new float[c];
                dmaxs[item] = new float[c];
                dnows[item] = new float[c];

                disCrcParts[item] = new bool[c];
                dlistSubProp[item] = new List<SubProp>[c];
                dMaidProp[item] = new MaidProp[c];
            }

            select();
        }

        public static void dmpnsSetup()
        {
            dmpns["Head"] = new MPN[]
            {
                MPN.HeadX,
                MPN.HeadY,

               // MPN.HandSize,
                MPN.FaceShape,
                MPN.FaceShapeSlim,
                MPN.KubiScl,
                //MPN.NeckThickX,
                //MPN.NeckThickY,
                //MPN.HohoShape,

                MPN.NosePos,
                MPN.NoseScl,

                //MPN.LipThick,
            };
            dmpns["Eye"] = new MPN[]
            {
                MPN.EyeScl,
                MPN.EyeSclX,
                MPN.EyeSclY,
                MPN.EyePosX,
                MPN.EyePosY,
                MPN.EyeClose,

                MPN.EyeBallPosX,
                MPN.EyeBallPosY,
                MPN.EyeBallSclX,
                MPN.EyeBallSclY,

                MPN.Yorime,
               //MPN.Eyedel,
               //MPN.Itome,


            };
            dmpns["Mabuta"] = new MPN[]
{
                //MPN.FutaePosX,
                //MPN.FutaePosY,
                //MPN.FutaeRot,

                MPN.MabutaUpIn,
                MPN.MabutaUpIn2,
                MPN.MabutaUpMiddle,
                MPN.MabutaUpOut,
                MPN.MabutaUpOut2,

                MPN.MabutaLowIn,
                MPN.MabutaLowUpMiddle,
                MPN.MabutaLowUpOut,
};

            dmpns["Mayu"] = new MPN[]
{
                MPN.MayuX,
                MPN.MayuY,
                MPN.MayuShapeIn,
                MPN.MayuShapeOut,
                MPN.MayuRot,
                MPN.MayuThick,
                MPN.MayuLong,
};
            dmpns["Ear"] = new MPN[]
            {
                MPN.EarNone,
                MPN.EarElf,
                MPN.EarRot,
                MPN.EarScl,
                            };
            dmpns["Mune"] = new MPN[] // 가슴
{
                MPN.MuneL,
                MPN.MuneS,
               // MPN.MuneM,
                MPN.MuneTare,
                MPN.MuneUpDown,
                MPN.MuneYori,
                MPN.MuneYawaraka,
               // MPN.MunePosX,
               // MPN.MunePosY,
               // MPN.MuneThick,
               // MPN.MuneLong,
               // MPN.MuneDir,
            };

            //dmpns["Dou"] = new MPN[]
            //{
            //    MPN.DouPer,
               // MPN.DouThick1X,
               // MPN.DouThick1Y,
               // MPN.DouThick2X,
               // MPN.DouThick2Y,
               // MPN.DouThick3X,
               // MPN.DouThick3Y,
               // MPN.DouThick4X,
               // MPN.DouThick4Y,
               // MPN.DouThick5X,
               // MPN.DouThick5Y,
            //};

            dmpns["body"] = new MPN[]
            {
                MPN.DouPer,
                MPN.sintyou,
                MPN.west,
              //  MPN.WearSuso,
              //  MPN.WaistPos,
                MPN.Hara,
                //MPN.HaraN,
                MPN.koshi,
                //MPN.HipSize,
                //MPN.HipRot,
            };
            dmpns["Arm"] = new MPN[]
{
                MPN.ArmL,
              //  MPN.UpperArmThickX,
              //  MPN.UpperArmThickY,
              //  MPN.LowerArmThickX,
              //  MPN.LowerArmThickY,
              //  MPN.UpperArmLowerThickX,
              //  MPN.UpperArmLowerThickY,
                MPN.kata, // 팔
                MPN.UdeScl,
    // MPN.ElbowThickX,
    // MPN.ElbowThickY,
    // MPN.WristThickX,
    // MPN.WristThickY,
    // MPN.ClavicleThick,
    // MPN.ShoulderThick,
    // MPN.ShoulderTension,
};
            // dmpns["Nyurin"] = new MPN[]
            // {
            //     MPN.Nyurin1,
            //     MPN.Nyurin2,
            //     MPN.Nyurin3,
            //     MPN.Nyurin4,
            //     MPN.Nyurin5,
            //     MPN.Nyurin6,
            //     MPN.Nyurin7,
            //     MPN.Nyurin8,
            // };

            //  dmpns["Hitomi"] = new MPN[]
            //  {
            //      MPN.HitomiHiPosX,
            //      MPN.HitomiHiPosY,
            //      MPN.HitomiHiSclY,
            //      MPN.HitomiShapeUp,
            //      MPN.HitomiShapeLow,
            //      MPN.HitomiShapeIn,
            //      MPN.HitomiShapeOutUp,
            //      MPN.HitomiShapeOutLow,
            //      MPN.HitomiRot,
            //  };
            //  dmpns["Chikubi"] = new MPN[]
            //  {
            //      MPN.ChikubiH,
            //      MPN.ChikubiK1,
            //      MPN.ChikubiK2,
            //      MPN.ChikubiK2_MuneS,
            //      MPN.ChikubiR,
            //      MPN.ChikubiW,
            //  };

            dmpns["Reg"] = new MPN[]
            {
                MPN.RegFat,
                MPN.RegMeet,
           //     MPN.ThighThickX,
           //     MPN.ThighThickY,
           //     MPN.ThighLowerThickX,
           //     MPN.ThighLowerThickY,
           //     MPN.ThighShin,
           //     MPN.KneeThickX,
           //     MPN.KneeThickY,
           //     MPN.CalfThickX,
           //     MPN.CalfThickY,
           //     MPN.AnkleThickX,
           //     MPN.AnkleThickY,
           //     MPN.MuscleSkin,
           //     MPN.FootSize,
           };
          // dmpns["etc"] = new MPN[]
          // {                                                                                   
          //     MPN.ChikubiWearTotsu,               
          //     MPN.KuikomiPants,
          //     MPN.KuikomiStkg,
          //    
          //     MPN.Hanasuji,
          //     MPN.Washibana,
          //
          //     MPN.Ha1,
          //     MPN.Ha2,
          //     MPN.Ha3,
          //     MPN.Ha4,
          //     MPN.Ha5,
          //     MPN.Ha6,
          // };

        }

        public static void select()
        {
            string s = dKeys[akey];

            acnt = dcnt[s];

            ampns = dmpns[s];
            anames = dnames[s];

            amins = dmins[s];
            amaxs = dmaxs[s];
            anows = dnows[s];

            aisCrcParts = disCrcParts[s];
            alistSubProp = dlistSubProp[s];
            aMaidProp = dMaidProp[s];
        }

        public static Maid SetMaid(int seleted)
        {
            return SetMaid(MaidActiveUtill.GetMaid(seleted));
        }

        public static Maid SetMaid(Maid maid)
        {
            MPNUtill.maid = maid;
            if (maid != null)
            {
                for (int i = 0; i < acnt; i++)
                {
                    var p = aMaidProp[i] = maid.GetProp(ampns[i]);

                    anames[i] = p.name;

                    anows[i] = p.value;
                    amins[i] = p.min;
                    amaxs[i] = p.max;

                    //aisCrcParts[i] = p.isCrcParts;
                    alistSubProp[i] = p.listSubProp;
                }
                maidOn = true;
            }
            else
            {
                maidOn = false;
            }
            return MPNUtill.maid;
        }
    }
}
