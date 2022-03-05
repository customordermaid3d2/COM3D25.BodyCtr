using LillyUtill.MyMaidActive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM3D25.BodyCtr
{
    public static class MPNUtill
    {
        public static Maid maid;

        public static int cnt;

        public static MPN[] mpns;
        //public static int[] valus;
        public static string[] names;

        public static float[] mins;
        public static float[] maxs;
        public static float[] nows;
        //public static float[] nowsb;

        public static bool[] isCrcParts;
        public static List<SubProp>[] listSubProp;

		//
		public static Dictionary<string, int> kategorie;

		public static void init()
        {
			init2();
			//mpns = (MPN[])Enum.GetValues(typeof(MPN));
            cnt = mpns.Length;

            //names = Enum.GetNames(typeof(MPN));
			names=Array.ConvertAll(mpns, value => value.ToString());

			mins = new float[cnt];
            maxs = new float[cnt];
            nows = new float[cnt];
            //nowsb = new float[mpns.Length];
            //
            isCrcParts = new bool[cnt];
            listSubProp=new List<SubProp>[cnt];
        }

		public static void KategorieSet()
        {
			

		}

		public static MPN CreateProp(int minval, int maxval, int defval, MPN mpn, int type)
        {
			return mpn;
        }

		public static void init2()
        {
			mpns=new MPN[] {
			//CreateProp(0, int.MaxValue, 0, MPN.null_mpn, 0),
			CreateProp(0, 130, 10, MPN.MuneL, 1),
			CreateProp(0, 100, 0, MPN.MuneS, 1),
			CreateProp(0, 100, 0, MPN.MuneM, 1),
			CreateProp(0, 130, 10, MPN.MuneTare, 1),
			CreateProp(0, 100, 40, MPN.RegFat, 1),
			CreateProp(0, 100, 20, MPN.ArmL, 1),
			CreateProp(0, 100, 20, MPN.Hara, 1),
			CreateProp(0, 100, 40, MPN.RegMeet, 1),
			CreateProp(20, 80, 50, MPN.KubiScl, 2),
			CreateProp(0, 100, 50, MPN.UdeScl, 2),
			CreateProp(0, 100, 50, MPN.EyeScl, 2),
			CreateProp(0, 100, 50, MPN.EyeSclX, 2),
			CreateProp(0, 100, 50, MPN.EyeSclY, 2),
			CreateProp(0, 100, 50, MPN.EyePosX, 2),
			CreateProp(0, 100, 50, MPN.EyePosY, 2),
			CreateProp(0, 100, 0, MPN.EyeClose, 2),
			CreateProp(0, 100, 50, MPN.EyeBallPosX, 2),
			CreateProp(0, 100, 50, MPN.EyeBallPosY, 2),
			CreateProp(-25, 100, 50, MPN.EyeBallSclX, 2),
			CreateProp(-25, 100, 50, MPN.EyeBallSclY, 2),
			CreateProp(0, 1, 0, MPN.EarNone, 2),
			CreateProp(0, 100, 0, MPN.EarElf, 2),
			CreateProp(0, 100, 50, MPN.EarRot, 2),
			CreateProp(0, 100, 50, MPN.EarScl, 2),
			CreateProp(0, 100, 50, MPN.NosePos, 2),
			CreateProp(0, 100, 50, MPN.NoseScl, 2),
			CreateProp(0, 100, 0, MPN.FaceShape, 2),
			CreateProp(0, 100, 0, MPN.FaceShapeSlim, 2),
			CreateProp(0, 100, 50, MPN.MayuShapeIn, 2),
			CreateProp(0, 100, 50, MPN.MayuShapeOut, 2),
			CreateProp(0, 100, 50, MPN.MayuX, 2),
			CreateProp(0, 100, 50, MPN.MayuY, 2),
			CreateProp(0, 100, 50, MPN.MayuRot, 2),
			CreateProp(0, 100, 50, MPN.HeadX, 2),
			CreateProp(0, 100, 50, MPN.HeadY, 2),
			CreateProp(20, 80, 50, MPN.DouPer, 2),
			CreateProp(20, 80, 50, MPN.sintyou, 2),
			CreateProp(0, 100, 50, MPN.koshi, 2),
			CreateProp(0, 100, 50, MPN.kata, 2),
			CreateProp(0, 100, 50, MPN.west, 2),
			CreateProp(0, 100, 10, MPN.MuneUpDown, 2),
			CreateProp(0, 100, 40, MPN.MuneYori, 2),
			CreateProp(0, 100, 50, MPN.MuneYawaraka, 2),
			CreateProp(0, 100, 50, MPN.MunePosX, 2),
			CreateProp(0, 100, 50, MPN.MunePosY, 2),
			CreateProp(0, 100, 50, MPN.MuneThick, 2),
			CreateProp(0, 100, 50, MPN.MuneLong, 2),
			CreateProp(0, 100, 50, MPN.MuneDir, 2),
			CreateProp(0, 100, 50, MPN.DouThick1X, 2),
			CreateProp(0, 100, 50, MPN.DouThick1Y, 2),
			CreateProp(0, 100, 50, MPN.DouThick2X, 2),
			CreateProp(0, 100, 50, MPN.DouThick2Y, 2),
			CreateProp(0, 100, 50, MPN.DouThick3X, 2),
			CreateProp(0, 100, 50, MPN.DouThick3Y, 2),
			CreateProp(0, 100, 50, MPN.ShoulderThick, 2),
			CreateProp(0, 100, 50, MPN.UpperArmThickX, 2),
			CreateProp(0, 100, 50, MPN.UpperArmThickY, 2),
			CreateProp(0, 100, 50, MPN.LowerArmThickX, 2),
			CreateProp(0, 100, 50, MPN.LowerArmThickY, 2),
			CreateProp(0, 100, 50, MPN.ElbowThickX, 2),
			CreateProp(0, 100, 50, MPN.ElbowThickY, 2),
			CreateProp(0, 100, 50, MPN.NeckThickX, 2),
			CreateProp(0, 100, 50, MPN.NeckThickY, 2),
			CreateProp(0, 100, 50, MPN.HandSize, 2),
			CreateProp(0, 100, 50, MPN.DouThick4X, 2),
			CreateProp(0, 100, 50, MPN.DouThick4Y, 2),
			CreateProp(0, 100, 50, MPN.DouThick5X, 2),
			CreateProp(0, 100, 50, MPN.DouThick5Y, 2),
			CreateProp(0, 100, 50, MPN.WaistPos, 2),
			CreateProp(0, 100, 50, MPN.HipSize, 1),
			CreateProp(0, 100, 50, MPN.HipRot, 2),
			CreateProp(0, 100, 43, MPN.ThighThickX, 2),
			CreateProp(0, 100, 40, MPN.ThighThickY, 2),
			CreateProp(0, 100, 35, MPN.KneeThickX, 2),
			CreateProp(0, 100, 35, MPN.KneeThickY, 2),
			CreateProp(0, 100, 35, MPN.CalfThickX, 2),
			CreateProp(0, 100, 38, MPN.CalfThickY, 2),
			CreateProp(0, 100, 35, MPN.AnkleThickX, 2),
			CreateProp(0, 100, 43, MPN.AnkleThickY, 2),
			CreateProp(0, 100, 50, MPN.FootSize, 2),
			CreateProp(0, 100, 50, MPN.UpperArmLowerThickX, 2),
			CreateProp(0, 100, 50, MPN.UpperArmLowerThickY, 2),
			CreateProp(0, 100, 50, MPN.WristThickX, 2),
			CreateProp(0, 100, 50, MPN.WristThickY, 2),
			CreateProp(0, 100, 50, MPN.ClavicleThick, 2),
			CreateProp(0, 100, 50, MPN.ShoulderTension, 2),
			CreateProp(0, 100, 35, MPN.ThighLowerThickX, 2),
			CreateProp(0, 100, 43, MPN.ThighLowerThickY, 2),
			CreateProp(0, 100, 50, MPN.ThighShin, 2),
			CreateProp(0, 100, 0, MPN.HaraN, 1),
			CreateProp(0, 100, 20, MPN.ChikubiH, 1),
			CreateProp(0, 100, 0, MPN.ChikubiK1, 1),
			CreateProp(0, 100, 0, MPN.ChikubiK2, 1),
			CreateProp(0, 100, 0, MPN.ChikubiK2_MuneS, 1),
			CreateProp(0, 100, 10, MPN.ChikubiR, 1),
			CreateProp(0, 100, 20, MPN.ChikubiW, 1),
			CreateProp(0, 100, 0, MPN.Nyurin1, 1),
			CreateProp(0, 100, 0, MPN.Nyurin2, 1),
			CreateProp(0, 100, 20, MPN.Nyurin3, 1),
			CreateProp(0, 100, 0, MPN.Nyurin4, 1),
			CreateProp(0, 100, 0, MPN.Nyurin5, 1),
			CreateProp(0, 100, 0, MPN.Nyurin6, 1),
			CreateProp(0, 100, 0, MPN.Nyurin7, 1),
			CreateProp(0, 100, 0, MPN.Nyurin8, 1),
			CreateProp(0, 100, 0, MPN.ChikubiWearTotsu, 1),
			CreateProp(0, 100, 50, MPN.MayuThick, 2),
			CreateProp(0, 100, 50, MPN.MayuLong, 2),
			CreateProp(0, 100, 50, MPN.Yorime, 2),
			CreateProp(0, 100, 50, MPN.MabutaUpIn, 1),
			CreateProp(0, 100, 50, MPN.MabutaUpIn2, 1),
			CreateProp(0, 100, 50, MPN.MabutaUpMiddle, 1),
			CreateProp(0, 100, 50, MPN.MabutaUpOut, 1),
			CreateProp(0, 100, 50, MPN.MabutaUpOut2, 1),
			CreateProp(0, 100, 50, MPN.MabutaLowIn, 1),
			CreateProp(0, 100, 50, MPN.MabutaLowUpMiddle, 1),
			CreateProp(0, 100, 50, MPN.MabutaLowUpOut, 1),
			CreateProp(0, 100, 0, MPN.Eyedel, 1),
			CreateProp(0, 100, 0, MPN.Itome, 1),
			CreateProp(0, 100, 0, MPN.Ha1, 1),
			CreateProp(0, 100, 0, MPN.Ha2, 1),
			CreateProp(0, 100, 0, MPN.Ha3, 1),
			CreateProp(0, 100, 0, MPN.Ha4, 1),
			CreateProp(0, 100, 0, MPN.Ha5, 1),
			CreateProp(0, 100, 0, MPN.Ha6, 1),
			CreateProp(0, 100, 50, MPN.FutaePosX, 2),
			CreateProp(0, 100, 50, MPN.FutaePosY, 2),
			CreateProp(0, 100, 50, MPN.FutaeRot, 2),
			CreateProp(0, 100, 50, MPN.HitomiHiPosX, 2),
			CreateProp(0, 100, 50, MPN.HitomiHiPosY, 2),
			CreateProp(0, 80, 50, MPN.HitomiHiSclY, 2),
			CreateProp(0, 100, 0, MPN.HitomiShapeUp, 1),
			CreateProp(0, 100, 0, MPN.HitomiShapeLow, 1),
			CreateProp(0, 100, 0, MPN.HitomiShapeIn, 1),
			CreateProp(0, 100, 0, MPN.HitomiShapeOutUp, 1),
			CreateProp(0, 100, 0, MPN.HitomiShapeOutLow, 1),
			CreateProp(0, 100, 50, MPN.HitomiRot, 2),
			CreateProp(0, 100, 0, MPN.HohoShape, 1),
			CreateProp(0, 100, 0, MPN.LipThick, 1),
			CreateProp(0, 100, 0, MPN.WearSuso, 2),
			CreateProp(0, 100, 100, MPN.KuikomiPants, 1),
			CreateProp(0, 100, 100, MPN.KuikomiStkg, 1),
			CreateProp(0, 100, 0, MPN.MuscleSkin, 2),
			CreateProp(0, 100, 0, MPN.Hanasuji, 1),
			CreateProp(0, 100, 0, MPN.Washibana, 1),
			};
        }

        public static void SetMaid(int seleted)
        {
            maid = MaidActiveUtill.GetMaid(seleted);
            //MPNUtill.maid = maid;
            for (int i = 0; i < cnt; i++)
            {
                var p=maid.GetProp(mpns[i]);
                
                names[i]=p.name ;

                nows[i]=p.value ;
                mins[i]=p.min ;
                maxs[i]=p.max ;

                isCrcParts[i]=p.isCrcParts ;
                listSubProp[i]=p.listSubProp ;
            }            
        }

		/// <summary>
		/// 참고용
		/// </summary>
		/// <returns></returns>
		/*
		public static List<MaidProp> CreateInitMaidPropList()
		{
			return new List<MaidProp>
		{
			Maid.CreateProp(0, int.MaxValue, 0, MPN.null_mpn, 0),
			Maid.CreateProp(0, 130, 10, MPN.MuneL, 1),
			Maid.CreateProp(0, 100, 0, MPN.MuneS, 1),
			Maid.CreateProp(0, 100, 0, MPN.MuneM, 1),
			Maid.CreateProp(0, 130, 10, MPN.MuneTare, 1),
			Maid.CreateProp(0, 100, 40, MPN.RegFat, 1),
			Maid.CreateProp(0, 100, 20, MPN.ArmL, 1),
			Maid.CreateProp(0, 100, 20, MPN.Hara, 1),
			Maid.CreateProp(0, 100, 40, MPN.RegMeet, 1),
			Maid.CreateProp(20, 80, 50, MPN.KubiScl, 2),
			Maid.CreateProp(0, 100, 50, MPN.UdeScl, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyeScl, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyeSclX, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyeSclY, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyePosX, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyePosY, 2),
			Maid.CreateProp(0, 100, 0, MPN.EyeClose, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyeBallPosX, 2),
			Maid.CreateProp(0, 100, 50, MPN.EyeBallPosY, 2),
			Maid.CreateProp(-25, 100, 50, MPN.EyeBallSclX, 2),
			Maid.CreateProp(-25, 100, 50, MPN.EyeBallSclY, 2),
			Maid.CreateProp(0, 1, 0, MPN.EarNone, 2),
			Maid.CreateProp(0, 100, 0, MPN.EarElf, 2),
			Maid.CreateProp(0, 100, 50, MPN.EarRot, 2),
			Maid.CreateProp(0, 100, 50, MPN.EarScl, 2),
			Maid.CreateProp(0, 100, 50, MPN.NosePos, 2),
			Maid.CreateProp(0, 100, 50, MPN.NoseScl, 2),
			Maid.CreateProp(0, 100, 0, MPN.FaceShape, 2),
			Maid.CreateProp(0, 100, 0, MPN.FaceShapeSlim, 2),
			Maid.CreateProp(0, 100, 50, MPN.MayuShapeIn, 2),
			Maid.CreateProp(0, 100, 50, MPN.MayuShapeOut, 2),
			Maid.CreateProp(0, 100, 50, MPN.MayuX, 2),
			Maid.CreateProp(0, 100, 50, MPN.MayuY, 2),
			Maid.CreateProp(0, 100, 50, MPN.MayuRot, 2),
			Maid.CreateProp(0, 100, 50, MPN.HeadX, 2),
			Maid.CreateProp(0, 100, 50, MPN.HeadY, 2),
			Maid.CreateProp(20, 80, 50, MPN.DouPer, 2),
			Maid.CreateProp(20, 80, 50, MPN.sintyou, 2),
			Maid.CreateProp(0, 100, 50, MPN.koshi, 2),
			Maid.CreateProp(0, 100, 50, MPN.kata, 2),
			Maid.CreateProp(0, 100, 50, MPN.west, 2),
			Maid.CreateProp(0, 100, 10, MPN.MuneUpDown, 2),
			Maid.CreateProp(0, 100, 40, MPN.MuneYori, 2),
			Maid.CreateProp(0, 100, 50, MPN.MuneYawaraka, 2),
			Maid.CreateProp(0, 100, 50, MPN.MunePosX, 2),
			Maid.CreateProp(0, 100, 50, MPN.MunePosY, 2),
			Maid.CreateProp(0, 100, 50, MPN.MuneThick, 2),
			Maid.CreateProp(0, 100, 50, MPN.MuneLong, 2),
			Maid.CreateProp(0, 100, 50, MPN.MuneDir, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick1X, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick1Y, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick2X, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick2Y, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick3X, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick3Y, 2),
			Maid.CreateProp(0, 100, 50, MPN.ShoulderThick, 2),
			Maid.CreateProp(0, 100, 50, MPN.UpperArmThickX, 2),
			Maid.CreateProp(0, 100, 50, MPN.UpperArmThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.LowerArmThickX, 2),
			Maid.CreateProp(0, 100, 50, MPN.LowerArmThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.ElbowThickX, 2),
			Maid.CreateProp(0, 100, 50, MPN.ElbowThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.NeckThickX, 2),
			Maid.CreateProp(0, 100, 50, MPN.NeckThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.HandSize, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick4X, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick4Y, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick5X, 2),
			Maid.CreateProp(0, 100, 50, MPN.DouThick5Y, 2),
			Maid.CreateProp(0, 100, 50, MPN.WaistPos, 2),
			Maid.CreateProp(0, 100, 50, MPN.HipSize, 1),
			Maid.CreateProp(0, 100, 50, MPN.HipRot, 2),
			Maid.CreateProp(0, 100, 43, MPN.ThighThickX, 2),
			Maid.CreateProp(0, 100, 40, MPN.ThighThickY, 2),
			Maid.CreateProp(0, 100, 35, MPN.KneeThickX, 2),
			Maid.CreateProp(0, 100, 35, MPN.KneeThickY, 2),
			Maid.CreateProp(0, 100, 35, MPN.CalfThickX, 2),
			Maid.CreateProp(0, 100, 38, MPN.CalfThickY, 2),
			Maid.CreateProp(0, 100, 35, MPN.AnkleThickX, 2),
			Maid.CreateProp(0, 100, 43, MPN.AnkleThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.FootSize, 2),
			Maid.CreateProp(0, 100, 50, MPN.UpperArmLowerThickX, 2),
			Maid.CreateProp(0, 100, 50, MPN.UpperArmLowerThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.WristThickX, 2),
			Maid.CreateProp(0, 100, 50, MPN.WristThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.ClavicleThick, 2),
			Maid.CreateProp(0, 100, 50, MPN.ShoulderTension, 2),
			Maid.CreateProp(0, 100, 35, MPN.ThighLowerThickX, 2),
			Maid.CreateProp(0, 100, 43, MPN.ThighLowerThickY, 2),
			Maid.CreateProp(0, 100, 50, MPN.ThighShin, 2),
			Maid.CreateProp(0, 100, 0, MPN.HaraN, 1),
			Maid.CreateProp(0, 100, 20, MPN.ChikubiH, 1),
			Maid.CreateProp(0, 100, 0, MPN.ChikubiK1, 1),
			Maid.CreateProp(0, 100, 0, MPN.ChikubiK2, 1),
			Maid.CreateProp(0, 100, 0, MPN.ChikubiK2_MuneS, 1),
			Maid.CreateProp(0, 100, 10, MPN.ChikubiR, 1),
			Maid.CreateProp(0, 100, 20, MPN.ChikubiW, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin1, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin2, 1),
			Maid.CreateProp(0, 100, 20, MPN.Nyurin3, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin4, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin5, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin6, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin7, 1),
			Maid.CreateProp(0, 100, 0, MPN.Nyurin8, 1),
			Maid.CreateProp(0, 100, 0, MPN.ChikubiWearTotsu, 1),
			Maid.CreateProp(0, 100, 50, MPN.MayuThick, 2),
			Maid.CreateProp(0, 100, 50, MPN.MayuLong, 2),
			Maid.CreateProp(0, 100, 50, MPN.Yorime, 2),
			Maid.CreateProp(0, 100, 50, MPN.MabutaUpIn, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaUpIn2, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaUpMiddle, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaUpOut, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaUpOut2, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaLowIn, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaLowUpMiddle, 1),
			Maid.CreateProp(0, 100, 50, MPN.MabutaLowUpOut, 1),
			Maid.CreateProp(0, 100, 0, MPN.Eyedel, 1),
			Maid.CreateProp(0, 100, 0, MPN.Itome, 1),
			Maid.CreateProp(0, 100, 0, MPN.Ha1, 1),
			Maid.CreateProp(0, 100, 0, MPN.Ha2, 1),
			Maid.CreateProp(0, 100, 0, MPN.Ha3, 1),
			Maid.CreateProp(0, 100, 0, MPN.Ha4, 1),
			Maid.CreateProp(0, 100, 0, MPN.Ha5, 1),
			Maid.CreateProp(0, 100, 0, MPN.Ha6, 1),
			Maid.CreateProp(0, 100, 50, MPN.FutaePosX, 2),
			Maid.CreateProp(0, 100, 50, MPN.FutaePosY, 2),
			Maid.CreateProp(0, 100, 50, MPN.FutaeRot, 2),
			Maid.CreateProp(0, 100, 50, MPN.HitomiHiPosX, 2),
			Maid.CreateProp(0, 100, 50, MPN.HitomiHiPosY, 2),
			Maid.CreateProp(0, 80, 50, MPN.HitomiHiSclY, 2),
			Maid.CreateProp(0, 100, 0, MPN.HitomiShapeUp, 1),
			Maid.CreateProp(0, 100, 0, MPN.HitomiShapeLow, 1),
			Maid.CreateProp(0, 100, 0, MPN.HitomiShapeIn, 1),
			Maid.CreateProp(0, 100, 0, MPN.HitomiShapeOutUp, 1),
			Maid.CreateProp(0, 100, 0, MPN.HitomiShapeOutLow, 1),
			Maid.CreateProp(0, 100, 50, MPN.HitomiRot, 2),
			Maid.CreateProp(0, 100, 0, MPN.HohoShape, 1),
			Maid.CreateProp(0, 100, 0, MPN.LipThick, 1),
			Maid.CreateProp(0, 100, 0, MPN.WearSuso, 2),
			Maid.CreateProp(0, 100, 100, MPN.KuikomiPants, 1),
			Maid.CreateProp(0, 100, 100, MPN.KuikomiStkg, 1),
			Maid.CreateProp(0, 100, 0, MPN.MuscleSkin, 2),
			Maid.CreateProp(0, 100, 0, MPN.Hanasuji, 1),
			Maid.CreateProp(0, 100, 0, MPN.Washibana, 1),
			Maid.CreateProp(string.Empty, MPN.body, 3),
			Maid.CreateProp(string.Empty, MPN.head, 3),
			Maid.CreateProp(string.Empty, MPN.hairf, 3),
			Maid.CreateProp(string.Empty, MPN.hairr, 3),
			Maid.CreateProp(string.Empty, MPN.hairt, 3),
			Maid.CreateProp(string.Empty, MPN.hairs, 3),
			Maid.CreateProp(string.Empty, MPN.wear, 3),
			Maid.CreateProp(string.Empty, MPN.skirt, 3),
			Maid.CreateProp(string.Empty, MPN.mizugi, 3),
			Maid.CreateProp(string.Empty, MPN.mizugi_top, 3),
			Maid.CreateProp(string.Empty, MPN.mizugi_buttom, 3),
			Maid.CreateProp(string.Empty, MPN.bra, 3),
			Maid.CreateProp(string.Empty, MPN.panz, 3),
			Maid.CreateProp(string.Empty, MPN.slip, 3),
			Maid.CreateProp(string.Empty, MPN.stkg, 3),
			Maid.CreateProp(string.Empty, MPN.shoes, 3),
			Maid.CreateProp(string.Empty, MPN.headset, 3),
			Maid.CreateProp(string.Empty, MPN.glove, 3),
			Maid.CreateProp(string.Empty, MPN.acchead, 3),
			Maid.CreateProp(string.Empty, MPN.hairaho, 3),
			Maid.CreateProp(string.Empty, MPN.accha, 3),
			Maid.CreateProp(string.Empty, MPN.acchana, 3),
			Maid.CreateProp(string.Empty, MPN.accface, 3),
			Maid.CreateProp(string.Empty, MPN.acckamisub, 3),
			Maid.CreateProp(string.Empty, MPN.acckami, 3),
			Maid.CreateProp(string.Empty, MPN.accmimi, 3),
			Maid.CreateProp(string.Empty, MPN.accnip, 3),
			Maid.CreateProp(string.Empty, MPN.acckubi, 3),
			Maid.CreateProp(string.Empty, MPN.acckubiwa, 3),
			Maid.CreateProp(string.Empty, MPN.accheso, 3),
			Maid.CreateProp(string.Empty, MPN.accude, 3),
			Maid.CreateProp(string.Empty, MPN.accashi, 3),
			Maid.CreateProp(string.Empty, MPN.accsenaka, 3),
			Maid.CreateProp(string.Empty, MPN.accshippo, 3),
			Maid.CreateProp(string.Empty, MPN.acckoshi, 3),
			Maid.CreateProp(string.Empty, MPN.accanl, 3),
			Maid.CreateProp(string.Empty, MPN.accvag, 3),
			Maid.CreateProp(string.Empty, MPN.megane, 3),
			Maid.CreateProp(string.Empty, MPN.accxxx, 3),
			Maid.CreateProp(string.Empty, MPN.handitem, 3),
			Maid.CreateProp(string.Empty, MPN.acchat, 3),
			Maid.CreateProp(string.Empty, MPN.haircolor, 3),
			Maid.CreateProp(string.Empty, MPN.skin, 3),
			Maid.CreateProp(string.Empty, MPN.acctatoo, 3),
			Maid.CreateProp(string.Empty, MPN.accnail, 3),
			Maid.CreateProp(string.Empty, MPN.underhair, 3),
			Maid.CreateProp(string.Empty, MPN.asshair, 3),
			Maid.CreateProp(string.Empty, MPN.hokuro, 3),
			Maid.CreateProp(string.Empty, MPN.mayu, 3),
			Maid.CreateProp(string.Empty, MPN.lip, 3),
			Maid.CreateProp(string.Empty, MPN.eye, 3),
			Maid.CreateProp(string.Empty, MPN.eye_hi, 3),
			Maid.CreateProp(string.Empty, MPN.eye_hi_r, 3),
			Maid.CreateProp(string.Empty, MPN.chikubi, 3),
			Maid.CreateProp(string.Empty, MPN.chikubicolor, 3),
			Maid.CreateProp(string.Empty, MPN.eyewhite, 3),
			Maid.CreateProp(string.Empty, MPN.nose, 3),
			Maid.CreateProp(string.Empty, MPN.facegloss, 3),
			Maid.CreateProp(string.Empty, MPN.matsuge_up, 3),
			Maid.CreateProp(string.Empty, MPN.matsuge_low, 3),
			Maid.CreateProp(string.Empty, MPN.futae, 3),
			Maid.CreateProp(string.Empty, MPN.moza, 3),
			Maid.CreateProp(string.Empty, MPN.onepiece, 3),
			Maid.CreateProp(string.Empty, MPN.jacket, 3),
			Maid.CreateProp(string.Empty, MPN.vest, 3),
			Maid.CreateProp(string.Empty, MPN.shirt, 3),
			Maid.CreateProp(string.Empty, MPN.set_maidwear, 3),
			Maid.CreateProp(string.Empty, MPN.set_mywear, 3),
			Maid.CreateProp(string.Empty, MPN.set_underwear, 3),
			Maid.CreateProp(string.Empty, MPN.set_body, 3),
			Maid.CreateProp(string.Empty, MPN.set_face, 3),
			Maid.CreateProp(string.Empty, MPN.folder_eye, 3),
			Maid.CreateProp(string.Empty, MPN.folder_mayu, 3),
			Maid.CreateProp(string.Empty, MPN.folder_underhair, 3),
			Maid.CreateProp(string.Empty, MPN.folder_skin, 3),
			Maid.CreateProp(string.Empty, MPN.folder_eyewhite, 3),
			Maid.CreateProp(string.Empty, MPN.folder_matsuge_up, 3),
			Maid.CreateProp(string.Empty, MPN.folder_matsuge_low, 3),
			Maid.CreateProp(string.Empty, MPN.folder_futae, 3),
			Maid.CreateProp(string.Empty, MPN.kousoku_upper, 3),
			Maid.CreateProp(string.Empty, MPN.kousoku_lower, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_naka, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_hara, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_face, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_mune, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_hip, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_ude, 3),
			Maid.CreateProp(string.Empty, MPN.seieki_ashi, 3)
		};
		}
		*/
	}
}
