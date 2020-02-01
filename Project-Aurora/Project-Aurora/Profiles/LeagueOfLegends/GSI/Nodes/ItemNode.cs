﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Profiles.LeagueOfLegends.GSI.Nodes
{
    public class SlotNode : Node<SlotNode>
    {
        public bool HasItem;
        public bool CanUse;
        public bool Consumable;
        public int Count;
        public string Name = "";
        public ItemID Item = ItemID.None;

        public SlotNode()
        {

        }

        public SlotNode(_Item item)
        {
            CanUse = item.canUse;
            Consumable = item.consumable;
            Count = item.count;
            Name = item.displayName;

            if (Enum.IsDefined(typeof(ItemID), item.itemID))
                Item = (ItemID)item.itemID;
            else
                Console.WriteLine(item.itemID);

            HasItem = Item != ItemID.None;
        }
    }

    public enum ItemID
    {
        None = 0,
        BootsofSpeed = 1001,
        FaerieCharm = 1004,
        RejuvenationBead = 1006,
        GiantsBelt = 1011,
        CloakofAgility = 1018,
        BlastingWand = 1026,
        SapphireCrystal = 1027,
        RubyCrystal = 1028,
        ClothArmor = 1029,
        ChainVest = 1031,
        NullMagicMantle = 1033,
        LongSword = 1036,
        Pickaxe = 1037,
        BFSword = 1038,
        HuntersTalisman = 1039,
        HuntersMachete = 1041,
        Dagger = 1042,
        RecurveBow = 1043,
        AmplifyingTome = 1052,
        VampiricScepter = 1053,
        DoransShield = 1054,
        DoransBlade = 1055,
        DoransRing = 1056,
        NegatronCloak = 1057,
        NeedlesslyLargeRod = 1058,
        DarkSeal = 1082,
        Cull = 1083,
        //Enchantment:Warrior = 1400,
        //Enchantment:Cinderhulk = 1401,
        //Enchantment:RunicEchoes = 1402,
        //Enchantment:Warrior = 1412,
        //Enchantment:Cinderhulk = 1413,
        //Enchantment:RunicEchoes = 1414,
        //Enchantment:Bloodrazor = 1416,
        //Enchantment:Bloodrazor = 1419,
        HealthPotion = 2003,
        ShowdownHealthPotion = 2006,
        TotalBiscuitofRejuvenation = 2009,
        TotalBiscuitofEverlastingWill = 2010,
        KircheisShard = 2015,
        RefillablePotion = 2031,
        CorruptingPotion = 2033,
        OraclesExtract = 2047,
        GuardiansHorn = 2051,
        PoroSnax = 2052,
        DietPoroSnax = 2054,
        ControlWard = 2055,
        ShurelyasReverie = 2065,
        ElixirofIron = 2138,
        ElixirofSorcery = 2139,
        ElixirofWrath = 2140,
        MinionDematerializer = 2403,
        CommencingStopwatch = 2419,
        Stopwatch = 2420,
        BrokenStopwatch = 2421,
        SlightlyMagicalBoots = 2422,
        //Stopwatch = 2423,
        //BrokenStopwatch = 2424,
        AbyssalMask = 3001,
        ArchangelsStaff = 3003,
        Manamune = 3004,
        BerserkersGreaves = 3006,
        //ArchangelsStaff(QuickCharge) = 3007,
        //Manamune(QuickCharge) = 3008,
        BootsofSwiftness = 3009,
        CatalystofAeons = 3010,
        SorcerersShoes = 3020,
        FrozenMallet = 3022,
        GlacialShroud = 3024,
        IcebornGauntlet = 3025,
        GuardianAngel = 3026,
        RodofAges = 3027,
        ChaliceofHarmony = 3028,
        //RodofAges(QuickCharge) = 3029,
        HextechGLP800 = 3030,
        InfinityEdge = 3031,
        MortalReminder = 3033,
        LastWhisper = 3035,
        LordDominiksRegards = 3036,
        SeraphsEmbrace = 3040,
        MejaisSoulstealer = 3041,
        Muramana = 3042,
        //Muramana = 3043,
        Phage = 3044,
        PhantomDancer = 3046,
        NinjaTabi = 3047,
        //SeraphsEmbrace = 3048,
        ZekesConvergence = 3050,
        JaurimsFist = 3052,
        SteraksGage = 3053,
        Sheen = 3057,
        SpiritVisage = 3065,
        Kindlegem = 3067,
        SunfireCape = 3068,
        TearoftheGoddess = 3070,
        BlackCleaver = 3071,
        Bloodthirster = 3072,
        //TearoftheGoddess(QuickCharge) = 3073,
        RavenousHydra = 3074,
        Thornmail = 3075,
        BrambleVest = 3076,
        Tiamat = 3077,
        TrinityForce = 3078,
        WardensMail = 3082,
        WarmogsArmor = 3083,
        OverlordsBloodmail = 3084,
        RunaansHurricane = 3085,
        Zeal = 3086,
        StatikkShiv = 3087,
        RabadonsDeathcap = 3089,
        WitsEnd = 3091,
        RapidFirecannon = 3094,
        Stormrazor = 3095,
        LichBane = 3100,
        Stinger = 3101,
        BansheesVeil = 3102,
        AegisoftheLegion = 3105,
        Redemption = 3107,
        FiendishCodex = 3108,
        KnightsVow = 3109,
        FrozenHeart = 3110,
        MercurysTreads = 3111,
        GuardiansOrb = 3112,
        AetherWisp = 3113,
        ForbiddenIdol = 3114,
        NashorsTooth = 3115,
        RylaisCrystalScepter = 3116,
        BootsofMobility = 3117,
        ExecutionersCalling = 3123,
        GuinsoosRageblade = 3124,
        CaulfieldsWarhammer = 3133,
        SerratedDirk = 3134,
        VoidStaff = 3135,
        HauntingGuise = 3136,
        DervishBlade = 3137,
        MercurialScimitar = 3139,
        QuicksilverSash = 3140,
        YoumuusGhostblade = 3142,
        RanduinsOmen = 3143,
        BilgewaterCutlass = 3144,
        HextechRevolver = 3145,
        HextechGunblade = 3146,
        DuskbladeofDraktharr = 3147,
        LiandrysTorment = 3151,
        HextechProtobelt01 = 3152,
        BladeoftheRuinedKing = 3153,
        Hexdrinker = 3155,
        MawofMalmortius = 3156,
        ZhonyasHourglass = 3157,
        IonianBootsofLucidity = 3158,
        SpearofShojin = 3161,
        Morellonomicon = 3165,
        AthenesUnholyGrail = 3174,
        HeadofKhaZix = 3175,
        UmbralGlaive = 3179,
        SanguineBlade = 3181,
        GuardiansHammer = 3184,
        LocketoftheIronSolari = 3190,
        SeekersArmguard = 3191,
        GargoyleStoneplate = 3193,
        AdaptiveHelm = 3194,
        HexCoremk1 = 3196,
        HexCoremk2 = 3197,
        PerfectHexCore = 3198,
        PrototypeHexCore = 3200,
        SpectresCowl = 3211,
        MikaelsCrucible = 3222,
        LudensEcho = 3285,
        WardingTotemTrinket = 3340,
        ArcaneSweeper = 3348,
        GreaterStealthTotemTrinket = 3361,
        GreaterVisionTotemTrinket = 3362,
        FarsightAlteration = 3363,
        OracleLens = 3364,
        MoltenEdge = 3371,
        ForgefireCape = 3373,
        RabadonsDeathcrown = 3374,
        InfernalMask = 3379,
        ObsidianCleaver = 3380,
        Salvation = 3382,
        CircletoftheIronSolari = 3383,
        TrinityFusion = 3384,
        ZhonyasParadox = 3386,
        FrozenFist = 3387,
        YoumuusWraithblade = 3388,
        MightoftheRuinedKing = 3389,
        LudensPulse = 3390,
        YourCut = 3400,
        //HeadofKhaZix = 3410,
        //HeadofKhaZix = 3416,
        //HeadofKhaZix = 3422,
        //HeadofKhaZix = 3455,
        ArdentCenser = 3504,
        EssenceReaver = 3508,
        EyeoftheHerald = 3513,
        //EyeoftheHerald = 3514,
        GhostPoro = 3520,
        BlackSpear = 3599,
       // BlackSpear = 3600,
        //Enchantment:Warrior = 3671,
        //Enchantment:Cinderhulk = 3672,
        //Enchantment:RunicEchoes = 3673,
        //Enchantment:Bloodrazor = 3675,
        FrostedSnax = 3680,
        SuperSpicySnax = 3681,
        EspressoSnax = 3682,
        RainbowSnaxPartyPack = 3683,
        DawnbringerSnax = 3684,
        NightbringerSnax = 3685,
        CosmicShackle = 3690,
        SingularityLantern = 3691,
        DarkMatterScythe = 3692,
        GravityBoots = 3693,
        CloakofStars = 3694,
        DarkStarSigil = 3695,
        StalkersBlade = 3706,
        SkirmishersSabre = 3715,
        DeadMansPlate = 3742,
        TitanicHydra = 3748,
        BamisCinder = 3751,
        RighteousGlory = 3800,
        CrystallineBracer = 3801,
        LostChapter = 3802,
        DeathsDance = 3812,
        EdgeofNight = 3814,
        SpellthiefsEdge = 3850,
        Frostfang = 3851,
        ShardofTrueIce = 3853,
        SteelShoulderguards = 3854,
        RunesteelSpaulders = 3855,
        PauldronsofWhiterock = 3857,
        RelicShield = 3858,
        TargonsBuckler = 3859,
        BulwarkoftheMountain = 3860,
        SpectralSickle = 3862,
        HarrowingCrescent = 3863,
        BlackMistScythe = 3864,
        FireatWill = 3901,
        DeathsDaughter = 3902,
        RaiseMorale = 3903,
        TwinShadows = 3905,
        Spellbinder = 3907,
        OblivionOrb = 3916
    }
}
