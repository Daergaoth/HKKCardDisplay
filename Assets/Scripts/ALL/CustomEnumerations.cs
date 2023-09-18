using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomEnumerations{}

public enum DurationType
{
    NONE,
    ALLANDO,
}

public enum EffectType
{
    NONE,
    OSMAGIA,
    GYUJTOBOL_NEM_KERULHET_SEMMIBE,
    EXTRA_VP_REAGALNI
}

public enum Place
{
    NONE,
    SAJAT_PAKLI,
    SAJAT_KEZ,
    SAJAT_TARTALEK,
    SAJAT_ORPOSZT,
    SAJAT_KOVETO,
    SAJAT_SZABALYLAP,
    SAJAT_GYUJTO,
    SAJAT_SEMMI,
    SAJAT_BUBAJ,
    SAJAT_TARGY,
    ELLENFEL_PAKLI,
    ELLENFEL_KEZ,
    ELLENFEL_TARTALEK,
    ELLENFEL_ORPOSZT,
    ELLENFEL_KOVETO,
    ELLENFEL_SZABALYLAP,
    ELLENFEL_GYUJTO,
    ELLENFEL_SEMMI,
    ELLENFEL_BUBAJ,
    ELLENFEL_TARGY
}

public enum Target
{
    NONE,
    JATEKOS,
    ELLENFEL,
    SAJAT_PAKLI,
    ELLENFEL_PAKLI,
    SAJAT_KEZ,
    ELLENFEL_KEZ,
    SAJAT_TARTALEK,
    ELLENFEL_TARTALEK,
    SAJAT_ORPOSZT,
    ELLENFEL_ORPOSZT,
    SAJAT_GYUJTO,
    ELLENFEL_GYUJTO,
    SAJAT_SEMMI,
    ELLENFEL_SEMMI,
    SAJAT_KOVETO,
    ELLENFEL_KOVETO,
    SAJAT_SZABALYLAP,
    ELLENFEL_SZABALYLAP,
    SAJAT_BUBAJ,
    ELLENFEL_BUBAJ,
    SAJAT_TARGY,
    ELLENFEL_TARGY,
    SAJAT_EPITMENY,
    ELLENFEL_EPITMENY,
    SAJAT_HAJO,
    ELLENFEL_HAJO,
    SAJAT_LENY,
    ELLENFEL_LENY,
    SAJAT_SZORNY,
    ELLENFEL_SZORNY,
    SAJAT_TOKEN,
    ELLENFEL_TOKEN,
    SAJAT_KALANDOZO,
    ELLENFEL_KALANDOZO,
    SAJAT_GALETKI,
    ELLENFEL_GALETKI,
    SAJAT_MAGA
}

public enum Player
{
    NONE,
    JATEKOS,
    ELLENFEL
}

public enum Phase
{
    NONE,
    SAJAT_ELOKESZITO_EGY,
    SAJAT_ELOKESZITO_KETTO,
    SAJAT_HUZAS_EGY,
    SAJAT_HUZAS_KETTO,
    SAJAT_FO_EGY_EGY,
    SAJAT_FO_EGY_KETTO,
    SAJAT_CSERE_EGY,
    SAJAT_CSERE_KETTO,
    SAJAT_CSERE_UTANI_AZONNALI_EGY,
    SAJAT_CSERE_UTANI_AZONNALI_KETTO,
    SAJAT_HARC_EGY,
    SAJAT_HARC_KETTO,
    SAJAT_FO_KETTO_EGY,
    SAJAT_FO_KETTO_KETTO,
    SAJAT_GYOGYULAS_EGY,
    SAJAT_GYOGYULAS_KETTO,
    ELLENFEL_ELOKESZITO_EGY,
    ELLENFEL_ELOKESZITO_KETTO,
    ELLENFEL_HUZAS_EGY,
    ELLENFEL_HUZAS_KETTO,
    ELLENFEL_FO_EGY_EGY,
    ELLENFEL_FO_EGY_KETTO,
    ELLENFEL_CSERE_EGY,
    ELLENFEL_CSERE_KETTO,
    ELLENFEL_CSERE_UTANI_AZONNALI_EGY,
    ELLENFEL_CSERE_UTANI_AZONNALI_KETTO,
    ELLENFEL_HARC_EGY,
    ELLENFEL_HARC_KETTO,
    ELLENFEL_FO_KETTO_EGY,
    ELLENFEL_FO_KETTO_KETTO,
    ELLENFEL_GYOGYULAS_EGY,
    ELLENFEL_GYOGYULAS_KETTO
}

public enum ActionType
{
    NONE,
    PARENT,
    LAPKIJATSZAS,
    BLOKKOLAS,
    VP_SZERZES,
    LAP_HUZAS,
    LAP_VISSZAHUZAS_GYUJTOBOL,
    KIJATSZOTT_LAP_SEMMIBE_RAKASA,
    GYUJTOBOL_NEM_KERULHET_SEMMIBE,
    KEPESSEG_VALASZTAS_KIJATSZAS_ELOTT,
    VIZIO,
    REAGALAS
}

public enum Rarity
{
    NONE,
    GYAKORI,
    NEM_GYAKORI,
    RITKA,
    ULTRA_RITKA
}

public enum SummonCostType
{
    NONE,
    VP,
    SZK,
    EPITO,
    ALDOZAS,
    SEMMIZES,
    ZANSZILANK
}

public enum Icons
{
    NONE,
    ELETKIOLTO,
    ELOHOLT,
    EREKLYE,
    EROD,
    ETNIKUM,
    FA,
    FEM,
    HALO,
    HEGYMELYI,
    HIDEG,
    HORGONY,
    IDEZES,
    ISTENI,
    KEGY,
    KF,
    KINCS,
    KOD,
    LEGENDAS,
    MENTALIS,
    ORZO,
    OSMAGIA,
    REAKCIO_DRAGITAS,
    REPUL,
    REZISZTENCIA,
    SZORNYKOMPONENS,
    TUZ,
    VEDEKEZES,
    VILLAM,
    MAGIKUS_TAMADAS,
    MAGIKUS_VEDEKEZES,
    NORMAL_TAMADAS,
    NORMAL_VEDEKEZES,
    VP,
    SZK,
    EPITO,
    ALDOZAS,
    SEMMIZES,
    ZANSZILANK
}


public enum Group
{
    NONE,
    BUFA,
    BARD,
    CHARADIN,
    MUTANS,
    DORNODON,
    TOLVAJ,
    ELENIOS,
    PSZIONICISTA,
    FAIRLIGHT,
    MAGUS,
    LEAH,
    HALHATATLAN,
    RAIA,
    KATONA,
    SHERAN,
    TUDOS,
    THARR,
    TISZTOGATO,
    RHATT,
    SZINTELEN,
    KOVETO_SZABALYLAP
}

public enum MainType
{
    NONE,
    ALTALANOS,
    AVATAR,
    AZONNALI,
    BUBAJ,
    BUBAJ_BUBAJRA,
    BUBAJ_EPITMENYRE,
    BUBAJ_KALANDOZORA,
    BUBAJ_LAPRA,
    BUBAJ_LENYRE,
    BUBAJ_TARGYRA,
    CEH,
    EGYEB,
    EPITMENY,
    GALETKI,
    HELYSZIN,
    KALANDOZO,
    KOVETO,
    OSLICH,
    SZABALYLAP,
    SZAKERTELEM,
    SZINTLEPES,
    SZORNY,
    TARGY,
    TESTRESZ,
    TORZSZULOTT

}

public enum SubType
{
    NONE,
    ALAKVALTO,
    ANGYAL,
    ARNYMANO,
    BANYA,
    BAZALTELEMENTAL,
    BETEGSEG,
    BURASTYA,
    CHARADIN_FATTYA,
    CSAPDA,
    CSONTVAZ,
    DINO,
    DRUIDA,
    DZSINN,
    EBEN_IJASZ,
    EJFATTY,
    EKSZER,
    ELEKTROMOS,
    ELEMENTAL,
    ELF,
    EMBER,
    EPIKUS,
    FALU,
    FEGYVER,
    FEREG,
    FOKUSZKRISTALY,
    FONIX,
    GANUID,
    GNOM,
    GOBLIN,
    GOLEM,
    GRIFF,
    GROK_KEPZODMENY,
    HADVEZER,
    HAJO,
    HANGSZER,
    HATAS,
    HELYSZIN,
    HIDEG,
    HORDAPARANCSNOK,
    IJASZ,
    JEG,
    KALOZ,
    KAOSZSZELLEM,
    KIGYO,
    KISERTET,
    KOBUDERA,
    KOZOS_TUDAT,
    KRABBER,
    LEGELEMENTAL,
    LOVAS,
    MANO,
    MINOTAURUSZ,
    MOA,
    MORF,
    MOTYOGO,
    MUTANS,
    NEKROMANTA,
    NERUB,
    OLTAR,
    ORGLING,
    ORIAS,
    ORK,
    OSHANGYA,
    PAJZS,
    PANCEL,
    PEGAZUS,
    POK,
    POLIP,
    POLITIKA,
    PRAGLONC,
    PROFETA,
    PULZALO,
    QUWARG,
    QUWARG_BOLY,
    RAK,
    REAKCIO,
    SARKANY,
    SAV,
    SISAK,
    SKORPIO,
    SZENTELY,
    SZILMILL,
    SZINGULARIS,
    SZINGULARITAS,
    SZINTLEPES,
    SZINARUSZ,
    SZIREN,
    SZKRITTER,
    TEKNOS,
    TEMPLOM,
    TERMIK,
    THARGODAN,
    TOJAS,
    TORONY,
    TORPE,
    TRIKLEM_DRAKOLDER,
    TROGDOLITA,
    TROLL,
    TUZELEMENTAL,
    VAMPIR,
    VARKAUDAR,
    VEGZETUR,
    VERFARKAS,
    VILLAM,
    VIZ,
    VIZELEMENTAL,
    VIZIO,
    WOMATH,
    XENO,
    YETI,
    ZAN_INDUKATOR

}

public static class Extensions
{
    public static List<EnumKeyValuePairs> enumvalues = new();

    [System.Serializable]
    public class EnumKeyValuePairs
    {
        public Enum key;
        public string value;

        public EnumKeyValuePairs(Enum key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    //This is a extension class of enum
    public static string GetEnumDisplayNameTypeEnum(this Enum enumType)
    {


        if (enumvalues.Count == 0)
        {
            FillEnumValues();
        }
        return (from e in enumvalues
                where e.key == enumType
                select e.value).ToList().First();
    }


    public static Enum GetEnumValueByDisplayName(this Enum enumType, string target)
    {


        if (enumvalues.Count == 0)
        {
            FillEnumValues();
        }

        /*return (from e in enumvalues
                where e.value == target.Trim() && e.key.GetType() == enumType.GetType()
                select e.key).ToList().First();*/

        if (target.Length > 0)
        {
            return (from e in enumvalues
                             where e.value.ToLower() == target.ToLower().Trim() && e.key.GetType() == enumType.GetType()
                             select e.key).ToList().First();
        }
        else
        {
            return (from e in enumvalues
                    where e.key.ToString() == "NONE" && e.key.GetType() == enumType.GetType()
                    select e.key).ToList().First();
        }
    }

    private static void FillEnumValues()
    {
        enumvalues.Add(new EnumKeyValuePairs(DurationType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(EffectType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Place.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Target.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Player.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(Group.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.NONE, "None"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.NONE, "None"));

        // DurationType Enum
        enumvalues.Add(new EnumKeyValuePairs(DurationType.ALLANDO, "�lland�"));

        // EffectType Enum
        enumvalues.Add(new EnumKeyValuePairs(EffectType.OSMAGIA, "�sm�gia"));
        enumvalues.Add(new EnumKeyValuePairs(EffectType.GYUJTOBOL_NEM_KERULHET_SEMMIBE, "Gy�jt�b�l Nem Ker�lhet Semmibe"));
        enumvalues.Add(new EnumKeyValuePairs(EffectType.EXTRA_VP_REAGALNI, "+X VP reag�lni r�"));

        // Place Enum
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_PAKLI, "Saj�t Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_KEZ, "Saj�t K�z"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_TARTALEK, "Saj�t Tartal�k"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_ORPOSZT, "Saj�t �rposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_KOVETO, "Saj�t K�vet�"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_SZABALYLAP, "Saj�t Szab�lylap"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_GYUJTO, "Saj�t Gy�jt�"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_SEMMI, "Saj�t Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_BUBAJ, "Saj�t Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Place.SAJAT_TARGY, "Saj�t T�rgy"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_PAKLI, "Ellenf�l Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_KEZ, "Ellenf�l K�z"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_TARTALEK, "Ellenf�l Tartal�k"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_ORPOSZT, "Ellenf�l �rposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_KOVETO, "Ellenf�l K�vet�"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_SZABALYLAP, "Ellenf�l Szab�lylap"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_GYUJTO, "Ellenf�l Gy�jt�"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_SEMMI, "Ellenf�l Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_BUBAJ, "Ellenf�l B�b�j"));
        enumvalues.Add(new EnumKeyValuePairs(Place.ELLENFEL_TARGY, "Ellenf�l T�rgy"));

        // Target Enum
        enumvalues.Add(new EnumKeyValuePairs(Target.JATEKOS, "J�t�kos"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL, "Ellenf�l"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_PAKLI, "Saj�t Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_PAKLI, "Ellenf�l Pakli"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_KEZ, "Saj�t K�z"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_KEZ, "Ellenf�l K�z"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_TARTALEK, "Saj�t Tartal�k"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_TARTALEK, "Ellenf�l Tartal�k"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_ORPOSZT, "Saj�t �rposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_ORPOSZT, "Ellenf�l �rposzt"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_GYUJTO, "Saj�t Gy�jt�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_GYUJTO, "Ellenf�l Gy�jt�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_SEMMI, "Saj�t Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_SEMMI, "Ellenf�l Semmi"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_KOVETO, "Saj�t K�vet�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_KOVETO, "Ellenf�l K�vet�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_SZABALYLAP, "Saj�t Szab�lylap"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_SZABALYLAP, "Ellenf�l Szab�lylap"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_BUBAJ, "Saj�t B�b�j"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_BUBAJ, "Ellenf�l B�b�j"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_TARGY, "Saj�t T�rgy"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_TARGY, "Ellenf�l T�rgy"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_EPITMENY, "Saj�t �p�tm�ny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_EPITMENY, "Ellenf�l �p�tm�ny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_HAJO, "Saj�t Haj�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_HAJO, "Ellenf�l Haj�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_LENY, "Saj�t L�ny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_LENY, "Ellenf�l L�ny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_SZORNY, "Saj�t Sz�rny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_SZORNY, "Ellenf�l Sz�rny"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_TOKEN, "Saj�t T�ken"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_TOKEN, "Ellenf�l T�ken"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_KALANDOZO, "Saj�t Kalandoz�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_KALANDOZO, "Ellenf�l Kalandoz�"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_GALETKI, "Saj�t Galetki"));
        enumvalues.Add(new EnumKeyValuePairs(Target.ELLENFEL_GALETKI, "Ellenf�l Galetki"));
        enumvalues.Add(new EnumKeyValuePairs(Target.SAJAT_MAGA, "Saj�t Maga"));

        // Player Enum
        enumvalues.Add(new EnumKeyValuePairs(Player.JATEKOS, "J�t�kos"));
        enumvalues.Add(new EnumKeyValuePairs(Player.ELLENFEL, "Ellenf�l"));

        // Phase Enum
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_ELOKESZITO_EGY, "Saj�t El�k�sz�t� F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_ELOKESZITO_KETTO, "Saj�t El�k�sz�t� F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HUZAS_EGY, "Saj�t H�z�s F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HUZAS_KETTO, "Saj�t H�z�s F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_EGY_EGY, "Saj�t Els� F� F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_EGY_KETTO, "Saj�t Els� F� F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_EGY, "Saj�t Csere F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_KETTO, "Saj�t Csere F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_UTANI_AZONNALI_EGY, "Saj�t Csere F�zis Ut�ni Azonnali F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_CSERE_UTANI_AZONNALI_KETTO, "Saj�t Csere F�zis Ut�ni Azonnali F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HARC_EGY, "Saj�t Harc F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_HARC_KETTO, "Saj�t Harc F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_KETTO_EGY, "Saj�t M�sodik F� F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_FO_KETTO_KETTO, "Saj�t M�sodik F� F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_GYOGYULAS_EGY, "Saj�t Gy�gyul�si F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.SAJAT_GYOGYULAS_KETTO, "Saj�t Gy�gyul�si F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_ELOKESZITO_EGY, "Ellenf�l El�k�sz�t� F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_ELOKESZITO_KETTO, "Ellenf�l El�k�sz�t� F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HUZAS_EGY, "Ellenf�l H�z�s F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HUZAS_KETTO, "Ellenf�l H�z�s F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_EGY_EGY, "Ellenf�l Els� F� F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_EGY_KETTO, "Ellenf�l Els� F� F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_EGY, "Ellenf�l Csere F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_KETTO, "Ellenf�l Csere F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_UTANI_AZONNALI_EGY, "Ellenf�l Csere F�zis Ut�ni Azonnali F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_CSERE_UTANI_AZONNALI_KETTO, "Ellenf�l Csere F�zis Ut�ni Azonnali F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HARC_EGY, "Ellenf�l Harc F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_HARC_KETTO, "Ellenf�l Harc F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_KETTO_EGY, "Ellenf�l M�sodik F� F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_FO_KETTO_KETTO, "Ellenf�l M�sodik F� F�zis Saj�t Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_GYOGYULAS_EGY, "Ellenf�l Gy�gyul�si F�zis Ellenf�l Akci�"));
        enumvalues.Add(new EnumKeyValuePairs(Phase.ELLENFEL_GYOGYULAS_KETTO, "Ellenf�l Gy�gyul�si F�zis Ellenf�l Akci�"));

        // ActionType Enum
        enumvalues.Add(new EnumKeyValuePairs(ActionType.PARENT, "Sz�l�"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.LAPKIJATSZAS, "Lapkij�tsz�s"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.BLOKKOLAS, "Blokkol�s"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.VP_SZERZES, "VP Szerz�s"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.LAP_HUZAS, "Lap h�z�s"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.LAP_VISSZAHUZAS_GYUJTOBOL, "Lap Visszah�z�s Gy�t�b�l"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.KIJATSZOTT_LAP_SEMMIBE_RAKASA, "Kij�szott Lap Semmibe Rak�sa"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.KEPESSEG_VALASZTAS_KIJATSZAS_ELOTT, "K�pess�g V�laszt�s Kij�tsz�s El�tt"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.VIZIO, "V�zi�"));
        enumvalues.Add(new EnumKeyValuePairs(ActionType.REAGALAS, "Reag�l�s"));


        // Rarity Enum
        enumvalues.Add(new EnumKeyValuePairs(Rarity.GYAKORI, "Gyakori"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.NEM_GYAKORI, "Nem Gyakori"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.RITKA, "Ritka"));
        enumvalues.Add(new EnumKeyValuePairs(Rarity.ULTRA_RITKA, "Ultra Ritka"));

        // SummonCostType

        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.VP, "Var�zs Pont"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.SZK, "Sz�rnykomponens"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.EPITO, "�p�t�"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.ALDOZAS, "�ldoz�s"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.SEMMIZES, "Semmiz�s"));
        enumvalues.Add(new EnumKeyValuePairs(SummonCostType.ZANSZILANK, "Zanszil�nk"));

        // Icons
        enumvalues.Add(new EnumKeyValuePairs(Icons.ELETKIOLTO, "�let Kiolt�"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ELOHOLT, "�l�holt"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.EREKLYE, "Ereklye"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.EROD, "Er�d"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ETNIKUM, "Etnikum"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.FA, "Fa"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.FEM, "F�m"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HALO, "H�l�"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HEGYMELYI, "Hegym�lyi"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HIDEG, "Hideg"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.HORGONY, "Horgony"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.IDEZES, "Id�z�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ISTENI, "Isteni"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KEGY, "Kegy"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KF, "KF"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KINCS, "Kincs"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.KOD, "K�d"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.LEGENDAS, "Legend�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.MENTALIS, "Ment�lis"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ORZO, "�rz�"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.OSMAGIA, "�sm�gia"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.REAKCIO_DRAGITAS, "Reakci� Dr�g�t�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.REPUL, "Rep�l"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.REZISZTENCIA, "Rezisztencia"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.SZORNYKOMPONENS, "Sz�rnykomponens"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.TUZ, "T�z"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.VEDEKEZES, "V�dekez�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.VILLAM, "Vill�m"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.MAGIKUS_TAMADAS, "M�gikus T�mad�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.MAGIKUS_VEDEKEZES, "M�gikus V�dekez�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.NORMAL_TAMADAS, "Norm�l T�mad�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.NORMAL_VEDEKEZES, "Norm�l V�dekez�s"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.VP, "VP (Id�z�si k�lts�g)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.SZK, "SZK (Id�z�si k�lts�g)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.EPITO, "�p�t� (Id�z�si k�lts�g)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ALDOZAS, "�ldoz�s (Id�z�si k�lts�g)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.SEMMIZES, "Semmiz�s (Id�z�si k�lts�g)"));
        enumvalues.Add(new EnumKeyValuePairs(Icons.ZANSZILANK, "Zanszil�nk (Id�z�si k�lts�g)"));

        // Group Enum
        enumvalues.Add(new EnumKeyValuePairs(Group.BUFA, "Bufa"));
        enumvalues.Add(new EnumKeyValuePairs(Group.BARD, "B�rd"));
        enumvalues.Add(new EnumKeyValuePairs(Group.CHARADIN, "Chara-din"));
        enumvalues.Add(new EnumKeyValuePairs(Group.MUTANS, "Mut�ns"));
        enumvalues.Add(new EnumKeyValuePairs(Group.DORNODON, "Dornodon"));
        enumvalues.Add(new EnumKeyValuePairs(Group.TOLVAJ, "Tolvaj"));
        enumvalues.Add(new EnumKeyValuePairs(Group.ELENIOS, "Elenios"));
        enumvalues.Add(new EnumKeyValuePairs(Group.PSZIONICISTA, "Pszionicista"));
        enumvalues.Add(new EnumKeyValuePairs(Group.FAIRLIGHT, "Fairlight"));
        enumvalues.Add(new EnumKeyValuePairs(Group.MAGUS, "M�gus"));
        enumvalues.Add(new EnumKeyValuePairs(Group.LEAH, "Leah"));
        enumvalues.Add(new EnumKeyValuePairs(Group.HALHATATLAN, "Halhatatlan"));
        enumvalues.Add(new EnumKeyValuePairs(Group.RAIA, "Raia"));
        enumvalues.Add(new EnumKeyValuePairs(Group.KATONA, "Katona"));
        enumvalues.Add(new EnumKeyValuePairs(Group.SHERAN, "Sheran"));
        enumvalues.Add(new EnumKeyValuePairs(Group.TUDOS, "Tud�s"));
        enumvalues.Add(new EnumKeyValuePairs(Group.THARR, "Tharr"));
        enumvalues.Add(new EnumKeyValuePairs(Group.TISZTOGATO, "Tisztogat�"));
        enumvalues.Add(new EnumKeyValuePairs(Group.RHATT, "Rhatt"));
        enumvalues.Add(new EnumKeyValuePairs(Group.SZINTELEN, "Sz�ntelen"));
        enumvalues.Add(new EnumKeyValuePairs(Group.KOVETO_SZABALYLAP, "K�vet�/Szab�lylap"));
        enumvalues.Add(new EnumKeyValuePairs(Group.NONE, "Nincs"));

        // MainType
        enumvalues.Add(new EnumKeyValuePairs(MainType.ALTALANOS, "�ltal�nos"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.AVATAR, "Avat�r"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.AZONNALI, "Azonnali"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ, "B�b�j"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_BUBAJRA, "B�b�j B�b�jra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_EPITMENYRE, "B�b�j �p�tm�nyre"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_KALANDOZORA, "B�b�j Kalandoz�ra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_LAPRA, "B�b�j Lapra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_LENYRE, "B�b�j L�nyre"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.BUBAJ_TARGYRA, "B�b�j T�rgyra"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.CEH, "C�h"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.EGYEB, "Egy�b"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.EPITMENY, "�p�tm�ny"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.GALETKI, "Galetki"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.HELYSZIN, "Helysz�n"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.KALANDOZO, "Kalandoz�"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.KOVETO, "K�vet�"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.OSLICH, "�slich"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZABALYLAP, "Szab�lylap"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZAKERTELEM, "Szak�rtelem"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZINTLEPES, "Szintl�p�s"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.SZORNY, "Sz�rny"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.TARGY, "T�rgy"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.TESTRESZ, "Testr�sz"));
        enumvalues.Add(new EnumKeyValuePairs(MainType.TORZSZULOTT, "Torzsz�l�tt"));

        // SubType
        enumvalues.Add(new EnumKeyValuePairs(SubType.NONE, ""));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ALAKVALTO, "Alakv�lt�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ANGYAL, "Angyal"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ARNYMANO, "�rnyman�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BANYA, "B�nya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BAZALTELEMENTAL, "BazaltElement�l"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BETEGSEG, "Betegs�g"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.BURASTYA, "Bur�stya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.CHARADIN_FATTYA, "Chara-din Fattya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.CSAPDA, "Csapda"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.CSONTVAZ, "Csontv�z"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.DINO, "Din�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.DRUIDA, "Druida"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.DZSINN, "Dzsinn"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EBEN_IJASZ, "�ben �j�sz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EJFATTY, "�jfatty"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EKSZER, "�kszer"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ELEKTROMOS, "Elektromos"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ELEMENTAL, "Element�l"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ELF, "Elf"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EMBER, "Ember"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.EPIKUS, "Epikus"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FALU, "Falu"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FEGYVER, "Fegyver"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FEREG, "F�reg"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FOKUSZKRISTALY, "F�kuszkrist�ly"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.FONIX, "F�nix"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GANUID, "Gan�id"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GNOM, "Gn�m"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GOBLIN, "Goblin"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GOLEM, "G�lem"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GRIFF, "Griff"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.GROK_KEPZODMENY, "Grok K�pz�dm�ny"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HADVEZER, "Hadvez�r"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HAJO, "Haj�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HANGSZER, "Hangszer"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HATAS, "H�tas"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HELYSZIN, "Helysz�n"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HIDEG, "Hideg"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.HORDAPARANCSNOK, "Hordaparancsnok"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.IJASZ, "�j�sz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.JEG, "J�g"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KALOZ, "Kal�z"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KAOSZSZELLEM, "K�oszszellem"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KIGYO, "K�gy�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KISERTET, "K�s�rtet"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KOBUDERA, "Kobudera"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KOZOS_TUDAT, "K�z�s Tudat"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.KRABBER, "Krabber"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.LEGELEMENTAL, "L�gelement�l"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.LOVAS, "Lovas"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MANO, "Man�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MINOTAURUSZ, "Minotaurusz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MOA, "Moa"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MORF, "Morf"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MOTYOGO, "Motyog�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.MUTANS, "Mut�ns"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.NEKROMANTA, "Nekromanta"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.NERUB, "Nerub"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.OLTAR, "Olt�r"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ORGLING, "Orling"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ORIAS, "�ri�s"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ORK, "Ork"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.OSHANGYA, "�shangya"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PAJZS, "Pajzs"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PANCEL, "P�nc�l"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PEGAZUS, "Pegazus"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.POK, "P�k"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.POLIP, "Polip"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.POLITIKA, "Politika"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PRAGLONC, "Praglonc"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PROFETA, "Pr�f�ta"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.PULZALO, "Pulz�l�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.QUWARG, "Quwarg"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.QUWARG_BOLY, "Quwarg Boly"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.RAK, "R�k"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.REAKCIO, "Reakci�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SARKANY, "S�rk�ny"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SAV, "Sav"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SISAK, "Sisak"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SKORPIO, "Skorpi�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZENTELY, "Szent�ly"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZILMILL, "Szilmill"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINGULARIS, "Szingul�ris"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINGULARITAS, "Szingularit�s"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINTLEPES, "Szintl�p�s"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZINARUSZ, "Szin�rusz"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZIREN, "Szir�n"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.SZKRITTER, "Szkritter"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TEKNOS, "Tekn�s"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TEMPLOM, "Templom"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TERMIK, "Termik"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.THARGODAN, "Thargodan"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TOJAS, "Toj�s"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TORONY, "Torony"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TORPE, "T�rpe"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TRIKLEM_DRAKOLDER, "Triklem Drakolder"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TROGDOLITA, "Trogdolita"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TROLL, "Troll"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.TUZELEMENTAL, "T�zelement�l"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VAMPIR, "V�mp�r"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VARKAUDAR, "Varkaudar"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VEGZETUR, "V�gzet�r"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VERFARKAS, "V�rfarkas"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VILLAM, "Vill�m"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VIZ, "V�z"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VIZELEMENTAL, "V�zelement�l"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.VIZIO, "V�zi�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.WOMATH, "Womath"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.XENO, "Xen�"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.YETI, "Yeti"));
        enumvalues.Add(new EnumKeyValuePairs(SubType.ZAN_INDUKATOR, "Zan Induk�tor"));
    }
}

