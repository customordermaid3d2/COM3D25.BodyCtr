using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using COM3D2API;
using HarmonyLib;
using LillyUtill.MyMaidActive;
using LillyUtill.MyWindowRect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace COM3D25.BodyCtr
{
    class MyAttribute
    {
        public const string PLAGIN_NAME = "BodyCtr";
        public const string PLAGIN_VERSION = "22.3.5";
        public const string PLAGIN_FULL_NAME = "COM3D2.BodyCtr.Plugin";
    }

    // 버전 규칙 잇음. 반드시 2~4개의 숫자구성으로 해야함. 미준수시 못읽어들임
    [BepInPlugin(
        MyAttribute.PLAGIN_FULL_NAME,
        MyAttribute.PLAGIN_NAME,
        MyAttribute.PLAGIN_VERSION)]
    public class BodyCtr : BaseUnityPlugin
    {
        // Harmony harmony;
        public static ManualLogSource log;

        WindowRectUtill windowRect;
        private Vector2 scrollPosition;

        int seleted;
        bool maidOn;
        Maid maid = null;

        private static ConfigEntry<bool> isInfo;

        private void Awake()
        {
            log = Logger;
            Logger.LogMessage("Awake");

            isInfo = Config.Bind("cfg", "isInfo", false);

            MPNUtill.init();

            //rect = new Rect(10, 10, 100, 300);
            windowRect = new WindowRectUtill(
                Config,
                MyAttribute.PLAGIN_FULL_NAME,
                MyAttribute.PLAGIN_NAME,
                "SPL" // 최소화시 타이틀명
                );

            //harmony = Harmony.CreateAndPatchAll(typeof(BodyCtrPatch));
            MaidActiveUtill.setActiveMaidNum2 += MaidActiveUtill_setActiveMaidNum;
            MaidActiveUtill.deactivateMaidNum2 += MaidActiveUtill_deactivateMaidNum;
        }

        private void MaidActiveUtill_deactivateMaidNum(int arg1, Maid arg2)
        {
            if (arg1 == seleted) maidOn = false;
        }

        private void MaidActiveUtill_setActiveMaidNum(int arg1, Maid arg2)
        {
            if (arg1 == seleted)
            {
                maid = arg2;
                if (maid != null)
                {
                    MPNUtill.SetMaid(seleted);
                    maidOn = true;
                }
                else
                {
                    maidOn = false;
                }
            }
        }

        private void Start()
        {
            log.LogMessage("Start");

            // 기어 메뉴 추가. 이 플러그인 기능 자체를 멈추려면 enabled 를 꺽어야함. 그러면 OnEnable(), OnDisable() 이 작동함
            SystemShortcutAPI.AddButton(
                MyAttribute.PLAGIN_FULL_NAME,
                new Action(delegate () { windowRect.IsGUIOn = !windowRect.IsGUIOn; }),
                MyAttribute.PLAGIN_NAME,
                Properties.Resources.icon);
        }

        private void OnGUI()
        {
            if (!windowRect.IsGUIOn) // 지난 강좌에서 깜빡하고 빼먹은
                return;

            // UI창. 이거 없이 OnGUI 에서 WindowFunction 내용을 직접 구현해도 됨
            windowRect.WindowRect = GUILayout.Window(
                windowRect.winNum, windowRect.WindowRect, WindowFunction, "", GUI.skin.box);
        }

        private void WindowFunction(int id)
        {
            GUI.enabled = true; // 하위 GUI활성 가능. 커튼 클릭가능 같은것

            GUILayout.BeginHorizontal();
            GUILayout.Label(windowRect.windowName, GUILayout.Height(20));
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("-", GUILayout.Width(20), GUILayout.Height(20)))
            { windowRect.IsOpen = !windowRect.IsOpen; }
            if (GUILayout.Button("x", GUILayout.Width(20), GUILayout.Height(20)))
            { windowRect.IsGUIOn = false; }
            GUILayout.EndHorizontal();

            if (!windowRect.IsOpen)
            {   // 최소화시
            }
            else
            {   // 최대화시
                // 세로 스크롤 시작
                scrollPosition = GUILayout.BeginScrollView(scrollPosition);

                GUILayout.Label("Maid");
                seleted = MaidActiveUtill.SelectionGrid(seleted);
                if (GUI.changed)
                {
                    maid = MaidActiveUtill.GetMaid(seleted);
                    if (maid != null)
                    {
                        MPNUtill.SetMaid(maid);
                        maidOn = true;
                    }
                    else
                    {
                        maidOn = false;
                    }
                    GUI.changed = false;
                }

                if (GUILayout.Button($"isInfo {isInfo.Value}")) { isInfo.Value = !isInfo.Value; }
                if (maid != null && isInfo.Value) // maid.boMAN
                {
                    GUILayout.Label("info");
                    GUILayout.Label($"HasCrcBody {maid.HasCrcBody}");
                    GUILayout.Label($"HasNewRealMan {maid.HasNewRealMan}");
                    GUILayout.Label($"IsCrcBody {maid.IsCrcBody}");
                    GUILayout.Label($"IsAllProcPropBusy {maid.IsAllProcPropBusy}");
                    GUILayout.Label($"IsBusy {maid.IsBusy}");
                    GUILayout.Label($"IsDefaultRealManOnHScene {maid.IsDefaultRealManOnHScene}");
                    GUILayout.Label($"IsDefaultRealManOnNormalScene {maid.IsDefaultRealManOnNormalScene}");
                    GUILayout.Label($"IsNewManIsRealMan {maid.IsNewManIsRealMan}");
                    GUILayout.Label($"IsNowRealMan {maid.IsNowRealMan}");
                    GUILayout.Label($"isOffsetUpdateEnd {maid.isOffsetUpdateEnd}");
                    GUILayout.Label($"MayuDrawPriority {maid.MayuDrawPriority}");
                    GUILayout.Label($"MicLipSync {maid.MicLipSync}");
                }

                GUILayout.Label("edit");
                MPNUtill.akey = GUILayout.SelectionGrid(MPNUtill.akey, MPNUtill.dKeys, 4);
                if (GUI.changed)
                {
                    MPNUtill.select();
                    MPNUtill.SetMaid(maid);
                    GUI.changed = false;
                }

                GUILayout.Label("edit");
                GUI.enabled = maidOn;
                //if (maidOn)
                for (int i = 0; i < MPNUtill.acnt; i++)
                {
                    GUILayout.Label($"{MPNUtill.aMaidProp[i].idx} , {MPNUtill.anames[i]} , {MPNUtill.aisCrcParts[i]} , {MPNUtill.amins[i]} , {MPNUtill.amaxs[i]} , {MPNUtill.anows[i]} ");
                    //GUILayout.Label($"cnt {MPNUtill.listSubProp[i]?.Count}");
                    MPNUtill.anows[i] = GUILayout.HorizontalSlider(MPNUtill.anows[i], MPNUtill.amins[i], MPNUtill.amaxs[i]);
                    if (GUI.changed)
                    {
                        MPNUtill.maid.SetProp(MPNUtill.ampns[i], (int)MPNUtill.anows[i]);
                        MPNUtill.maid.AllProcProp();
                        GUI.changed = false;
                    }
                }

                GUILayout.EndScrollView();// 세로 스크롤 끝
            }
            GUI.enabled = true;
            GUI.DragWindow(); // 창을 잡고 이동 가능            
        }
    }
}
