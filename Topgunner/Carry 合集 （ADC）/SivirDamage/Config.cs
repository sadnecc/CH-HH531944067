﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK;


// ReSharper disable InconsistentNaming
// ReSharper disable MemberHidesStaticFromOuterClass
namespace SivirDamage
{
    // I can't really help you with my layout of a good config class
    // since everyone does it the way they like it most, go checkout my
    // config classes I make on my GitHub if you wanna take over the
    // complex way that I use
    public static class Config
    {
        private const string MenuName = "战场之伤西维尔";

        private static readonly Menu Menu;

        static Config()
        {
            // Initialize the menu
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Welcome to SivirDamage by TopGunner");
            Menu.AddGroupLabel("CARRY合集由CH汉化");

            // Initialize the modes
            Modes.Initialize();
        }

        public static void Initialize()
        {
        }


        public static class Misc
        {

            private static readonly Menu Menu;
            public static readonly CheckBox _drawQ;
            private static readonly CheckBox _ksQ;
            private static readonly CheckBox _useE;
            private static readonly CheckBox _useHeal;
            private static readonly CheckBox _useQSS;
            private static readonly CheckBox _autoBuyStartingItems;
            private static readonly CheckBox _autolevelskills;
            private static readonly Slider _skinId;
            public static readonly CheckBox _useSkinHack;
            private static readonly CheckBox[] _useHealOn = { new CheckBox("", false), new CheckBox("", false), new CheckBox("", false), new CheckBox("", false), new CheckBox("", false) };

            public static bool useHealOnI(int i)
            {
                return _useHealOn[i].CurrentValue;
            }
            public static bool ksQ
            {
                get { return _ksQ.CurrentValue; }
            }
            public static bool useE
            {
                get { return _useE.CurrentValue; }
            }
            public static int minDamage
            {
                get { return Menu["minDamageE"].Cast<Slider>().CurrentValue; }
            }
            public static bool useHeal
            {
                get { return _useHeal.CurrentValue; }
            }
            public static bool useQSS
            {
                get { return _useQSS.CurrentValue; }
            }
            public static bool autoBuyStartingItems
            {
                get { return _autoBuyStartingItems.CurrentValue; }
            }
            public static bool autolevelskills
            {
                get { return _autolevelskills.CurrentValue; }
            }
            public static int skinId
            {
                get { return _skinId.CurrentValue; }
            }
            public static bool UseSkinHack
            {
                get { return _useSkinHack.CurrentValue; }
            }


            static Misc()
            {
                // Initialize the menu values
                Menu = Config.Menu.AddSubMenu("杂项");
                _drawQ = Menu.Add("drawQ", new CheckBox("显示 Q"));
                Menu.AddSeparator();
                _ksQ = Menu.Add("ksQ", new CheckBox("智能Q抢头"));
                _useE = Menu.Add("useE", new CheckBox("使用 E"));
                Menu.Add("minDamageE", new Slider("最低生命伤害 % 才使用E", 20, 1, 100));
                Menu.AddSeparator();
                _useHeal = Menu.Add("useHeal", new CheckBox("智能使用治疗"));
                _useQSS = Menu.Add("useQSS", new CheckBox("使用水银"));
                Menu.AddSeparator();
                for (int i = 0; i < EntityManager.Heroes.Allies.Count; i++)
                {
                    _useHealOn[i] = Menu.Add("useHeal" + i, new CheckBox("使用治疗给 " + EntityManager.Heroes.Allies[i].ChampionName));
                }
                Menu.AddSeparator();
                _autolevelskills = Menu.Add("autolevelskills", new CheckBox("自动加点"));
                _autoBuyStartingItems = Menu.Add("autoBuyStartingItems", new CheckBox("开局自动购买物品 (召唤师峡谷)", false));
                Menu.AddSeparator();
                _useSkinHack = Menu.Add("useSkinHack", new CheckBox("换肤", false));
                _skinId = Menu.Add("skinId", new Slider("Skin ID", 5, 1, 9));
            }

            public static void Initialize()
            {
            }

        }

        public static class Modes
        {
            private static readonly Menu Menu;

            static Modes()
            {
                // Initialize the menu
                Menu = Config.Menu.AddSubMenu("模式");

                // Initialize all modes
                // Combo
                Combo.Initialize();
                Menu.AddSeparator();

                // Harass
                Harass.Initialize();
                LaneClear.Initialize();
                Flee.Initialize();
                JungleClear.Initialize();
            }

            public static void Initialize()
            {
            }

            public static class Combo
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useR;
                private static readonly CheckBox _useBOTRK;
                private static readonly CheckBox _useYOUMOUS;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }
                public static bool useBOTRK
                {
                    get { return _useBOTRK.CurrentValue; }
                }
                public static bool useYOUMOUS
                {
                    get { return _useYOUMOUS.CurrentValue; }
                }
                public static int damageMin
                {
                    get { return Menu["comboDamageMin"].Cast<Slider>().CurrentValue; }
                }
                public static int useRCount
                {
                    get { return Menu["comboMinEnemiesR"].Cast<Slider>().CurrentValue; }
                }

                static Combo()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("连招");
                    _useQ = Menu.Add("comboUseQ", new CheckBox("使用 Q"));
                    _useW = Menu.Add("comboUseW", new CheckBox("使用 W"));
                    _useR = Menu.Add("comboUseR", new CheckBox("使用 R"));
                    Menu.Add("comboDamageMin", new Slider("最低百分比Q 伤害", 40));
                    Menu.Add("comboMinEnemiesR", new Slider("600距离内敌人数量开启R", 2, 0, 5));
                    Menu.AddSeparator();
                    _useBOTRK = Menu.Add("useBotrk", new CheckBox("使用破败（智能）和小破败"));
                    _useYOUMOUS = Menu.Add("useYoumous", new CheckBox("使用幽梦"));
                }

                public static void Initialize()
                {
                }

            }

            public static class Harass
            {
                public static bool UseQ
                {
                    get { return Menu["harassUseQ"].Cast<CheckBox>().CurrentValue; }
                }
                public static bool UseW
                {
                    get { return Menu["harassUseW"].Cast<CheckBox>().CurrentValue; }
                }
                public static int Mana
                {
                    get { return Menu["harassMana"].Cast<Slider>().CurrentValue; }
                }
                public static int damageMin
                {
                    get { return Menu["harassDamageMin"].Cast<Slider>().CurrentValue; }
                }

                static Harass()
                {
                    // Here is another option on how to use the menu, but I prefer the
                    // way that I used in the combo class
                    Menu.AddGroupLabel("骚扰");
                    Menu.Add("harassUseQ", new CheckBox("使用 Q"));
                    Menu.Add("harassUseW", new CheckBox("使用 W"));

                    Menu.Add("harassDamageMin", new Slider("最低百分比Q 伤害", 60));

                    // Adding a slider, we have a little more options with them, using {0} {1} and {2}
                    // in the display name will replace it with 0=current 1=min and 2=max value
                    Menu.Add("harassMana", new Slider("最大蓝量使用百分比 ({0}%)", 40));
                }
                public static void Initialize()
                {
                }

            }

            public static class LaneClear
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly Slider _mana;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static int mana
                {
                    get { return _mana.CurrentValue; }
                }

                static LaneClear()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("清线");
                    _useQ = Menu.Add("clearUseQ", new CheckBox("使用 Q"));
                    _useW = Menu.Add("clearUseW", new CheckBox("使用 W"));
                    _mana = Menu.Add("clearMana", new Slider("最大蓝量使用百分比 ({0}%)", 40));
                }

                public static void Initialize()
                {
                }
            }
            public static class JungleClear
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly Slider _mana;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static int mana
                {
                    get { return _mana.CurrentValue; }
                }

                static JungleClear()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("清野");
                    _useQ = Menu.Add("jglUseQ", new CheckBox("使用 Q"));
                    _useW = Menu.Add("jglUseW", new CheckBox("使用 W"));
                    _mana = Menu.Add("jglMana", new Slider("最大蓝量使用百分比 ({0}%)", 40));
                }

                public static void Initialize()
                {
                }
            }
            public static class Flee
            {
                private static readonly CheckBox _useR;

                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }

                static Flee()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("逃跑");
                    _useR = Menu.Add("fleeUseR", new CheckBox("使用 R"));
                }

                public static void Initialize()
                {
                }
            }

        }
    }
}
