﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace Ex1L_Riven.Base
{
    internal class Variables
    {
        public static void Initialize()
        {
        }

        #region Combo Menu

        public static bool UseRCombo
        {
            get { return GetKeybind(MenuDesigner.ComboUi, "UseR"); }
        }

        public static bool UseFlashBurst
        {
            get { return GetCheckbox(MenuDesigner.ComboUi, "UseFlash"); }
        }

        #endregion

        #region Emote Menu

        public static bool UseEmoteCancel
        {
            get { return GetCheckbox(MenuDesigner.EmoteUi, "UseEmote"); }
        }

        public static string SelectedEmote
        {
            get { return MenuDesigner.EmoteUi["EmoteSelect"].Cast<ComboBox>().SelectedText; }
        }

        public static int Q1Q2Delay
        {
            get { return GetSlider(MenuDesigner.EmoteUi, "Q1Q2delay"); }
        }

        public static int Q3Delay
        {
            get { return GetSlider(MenuDesigner.EmoteUi, "Q3delay"); }
        }

        #endregion

        #region Clear Menu

        public static bool UseJungleE
        {
            get { return GetCheckbox(MenuDesigner.ClearUi, "JungleE"); }
        }

        public static bool UseJungleW
        {
            get { return GetCheckbox(MenuDesigner.ClearUi, "JungleW"); }
        }

        public static bool UseLaneE
        {
            get { return GetCheckbox(MenuDesigner.ClearUi, "LaneE"); }
        }

        public static bool UseLaneW
        {
            get { return GetCheckbox(MenuDesigner.ClearUi, "LaneW"); }
        }

        public static int MinMinionsW
        {
            get { return GetSlider(MenuDesigner.ClearUi, "Wminions"); }
        }

        #endregion

        #region Misc Menu

        public static bool UseAutoW
        {
            get { return GetCheckbox(MenuDesigner.MiscUi, "AutoW"); }
        }

        public static int MinEnemiesW
        {
            get { return GetSlider(MenuDesigner.MiscUi, "Wenemies"); }
        }

        public static bool UseInterruptW
        {
            get { return GetCheckbox(MenuDesigner.MiscUi, "InterW"); }
        }

        public static bool UseGapcloserWe
        {
            get { return GetCheckbox(MenuDesigner.MiscUi, "GapWE"); }
        }

        public static bool UseItems
        {
            get { return GetCheckbox(MenuDesigner.MiscUi, "UseItems"); }
        }

        #endregion

        #region Auto Level Menu

        public static bool UseAutoLevel
        {
            get { return GetCheckbox(MenuDesigner.LevelUi, "UseLevel"); }
        }

        public static string SelectedLevel
        {
            get { return MenuDesigner.LevelUi["SequenceSelect"].Cast<ComboBox>().SelectedText; }
        }

        public static int LevelDelay
        {
            get { return GetSlider(MenuDesigner.LevelUi, "LevelHumanizer"); }
        }

        #endregion

        #region Draw Menu

        public static bool DrawR1Status
        {
            get { return GetCheckbox(MenuDesigner.DrawUi, "Rstatus"); }
        }

        public static bool DrawR2Range
        {
            get { return GetCheckbox(MenuDesigner.DrawUi, "Rrange"); }
        }

        #endregion

        #region Menu Values

        // Return Checkbox Value
        public static bool GetCheckbox(Menu menu, string menuvalue)
        {
            return menu[menuvalue].Cast<CheckBox>().CurrentValue;
        }

        // Return Keybind Value
        public static bool GetKeybind(Menu menu, string menuvalue)
        {
            return menu[menuvalue].Cast<KeyBind>().CurrentValue;
        }

        // Return Slider Value
        public static int GetSlider(Menu menu, string menuvalue)
        {
            return menu[menuvalue].Cast<Slider>().CurrentValue;
        }

        #endregion
    }
}