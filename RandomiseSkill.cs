using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomiseSkill : MonoBehaviour
{
    [SerializeField] Image skillImege;
    [SerializeField] TextMeshProUGUI nameSkill;
    [SerializeField] List<Sprite> skillImages;
    [SerializeField] GameObject restartButton, quitButton;
    [SerializeField] Button startRollButton;

    int indeksSkill;
    string linkPoeDB;
    bool randomizeSkillEnd;

    private void Update()
    {
        PrintInfoSlills();
    }

    public void RollSlills()
    {
        indeksSkill = Random.Range(0, 182);
        randomizeSkillEnd = true;
        ShowSkillAtributes();
    }

    void PrintInfoSlills()
    {
        if (indeksSkill == 0)
        {
            skillImege.sprite = skillImages[0];
            nameSkill.text = "Absolution";
            linkPoeDB = "Absolution";
        }
        if (indeksSkill == 1)
        {
            skillImege.sprite = skillImages[1];
            nameSkill.text = "Ancestral Protector";
            linkPoeDB = "Ancestral_Protector";
        }
        if (indeksSkill == 2)
        {
            skillImege.sprite = skillImages[2];
            nameSkill.text = "Ancestral Warchief";
            linkPoeDB = "Ancestral_Warchief";
        }
        if (indeksSkill == 3)
        {
            skillImege.sprite = skillImages[3];
            nameSkill.text = "Animate Guardian";
            linkPoeDB = "Animate_Guardian";
        }
        if (indeksSkill == 4)
        {
            skillImege.sprite = skillImages[4];
            nameSkill.text = "Animate Weapon";
            linkPoeDB = "Animate_Weapon";
        }
        if (indeksSkill == 5)
        {
            skillImege.sprite = skillImages[5];
            nameSkill.text = "Arc";
            linkPoeDB = "Arc";
        }
        if (indeksSkill == 6)
        {
            skillImege.sprite = skillImages[6];
            nameSkill.text = "Arcanist Brand";
            linkPoeDB = "Arcanist_Brand";
        }
        if (indeksSkill == 7)
        {
            skillImege.sprite = skillImages[7];
            nameSkill.text = "Armageddon Brand";
            linkPoeDB = "Armageddon_Brand";
        }
        if (indeksSkill == 8)
        {
            skillImege.sprite = skillImages[8];
            nameSkill.text = "Artillery Ballista";
            linkPoeDB = "Artillery_Ballista";
        }
        if (indeksSkill == 9)
        {
            skillImege.sprite = skillImages[9];
            nameSkill.text = "Ball Lightning";
            linkPoeDB = "Ball_Lightning";
        }
        if (indeksSkill == 10)
        {
            skillImege.sprite = skillImages[10];
            nameSkill.text = "Barrage";
            linkPoeDB = "Barrage";
        }
        if (indeksSkill == 11)
        {
            skillImege.sprite = skillImages[11];
            nameSkill.text = "Bear Trap";
            linkPoeDB = "Bear_Trap";
        }
        if (indeksSkill == 12)
        {
            skillImege.sprite = skillImages[12];
            nameSkill.text = "Blade Blast";
            linkPoeDB = "Blade_Blast";
        }
        if (indeksSkill == 13)
        {
            skillImege.sprite = skillImages[13];
            nameSkill.text = "Blade Flurry";
            linkPoeDB = "Blade_Flurry";
        }
        if (indeksSkill == 14)
        {
            skillImege.sprite = skillImages[14];
            nameSkill.text = "Blade Trap";
            linkPoeDB = "Blade_Trap";
        }
        if (indeksSkill == 15)
        {
            skillImege.sprite = skillImages[15];
            nameSkill.text = "Blade Vortex";
            linkPoeDB = "Blade_Vortex";
        }
        if (indeksSkill == 16)
        {
            skillImege.sprite = skillImages[16];
            nameSkill.text = "Bladefall";
            linkPoeDB = "Bladefall";
        }
        if (indeksSkill == 17)
        {
            skillImege.sprite = skillImages[17];
            nameSkill.text = "Bladestorm";
            linkPoeDB = "Bladestorm";
        }
        if (indeksSkill == 18)
        {
            skillImege.sprite = skillImages[18];
            nameSkill.text = "Blast Rain";
            linkPoeDB = "Blast_Rain";
        }
        if (indeksSkill == 19)
        {
            skillImege.sprite = skillImages[19];
            nameSkill.text = "Blazing Salvo";
            linkPoeDB = "Blazing_Salvo";
        }
        if (indeksSkill == 20)
        {
            skillImege.sprite = skillImages[20];
            nameSkill.text = "Blight";
            linkPoeDB = "Blight";
        }
        if (indeksSkill == 21)
        {
            skillImege.sprite = skillImages[21];
            nameSkill.text = "Blink Arrow";
            linkPoeDB = "Blink_Arrow";
        }
        if (indeksSkill == 22)
        {
            skillImege.sprite = skillImages[22];
            nameSkill.text = "Bodyswap";
            linkPoeDB = "Bodyswap";
        }
        if (indeksSkill == 23)
        {
            skillImege.sprite = skillImages[23];
            nameSkill.text = "Boneshatter";
            linkPoeDB = "Boneshatter";
        }
        if (indeksSkill == 24)
        {
            skillImege.sprite = skillImages[24];
            nameSkill.text = "Brand Recall";
            linkPoeDB = "Brand_Recall";
        }
        if (indeksSkill == 25)
        {
            skillImege.sprite = skillImages[25];
            nameSkill.text = "Burning Arrow";
            linkPoeDB = "Burning_Arrow";
        }
        if (indeksSkill == 26)
        {
            skillImege.sprite = skillImages[26];
            nameSkill.text = "Caustic Arrow";
            linkPoeDB = "Caustic_Arrow";
        }
        if (indeksSkill == 27)
        {
            skillImege.sprite = skillImages[27];
            nameSkill.text = "Chain Hook";
            linkPoeDB = "Chain_Hook";
        }
        if (indeksSkill == 28)
        {
            skillImege.sprite = skillImages[28];
            nameSkill.text = "Charged Dash";
            linkPoeDB = "Charged_Dash";
        }
        if (indeksSkill == 29)
        {
            skillImege.sprite = skillImages[29];
            nameSkill.text = "Cleave";
            linkPoeDB = "Cleave";
        }
        if (indeksSkill == 30)
        {
            skillImege.sprite = skillImages[30];
            nameSkill.text = "Cobra Lash";
            linkPoeDB = "Cobra_Lash";
        }
        if (indeksSkill == 31)
        {
            skillImege.sprite = skillImages[31];
            nameSkill.text = "Cold Snap";
            linkPoeDB = "Cold_Snap";
        }
        if (indeksSkill == 32)
        {
            skillImege.sprite = skillImages[32];
            nameSkill.text = "Consecrated Path";
            linkPoeDB = "Consecrated_Path";
        }
        if (indeksSkill == 33)
        {
            skillImege.sprite = skillImages[33];
            nameSkill.text = "Contagion";
            linkPoeDB = "Contagion";
        }
        if (indeksSkill == 34)
        {
            skillImege.sprite = skillImages[34];
            nameSkill.text = "Conversion Trap";
            linkPoeDB = "Conversion_Trap";
        }
        if (indeksSkill == 35)
        {
            skillImege.sprite = skillImages[35];
            nameSkill.text = "Corrupting Fever";
            linkPoeDB = "Corrupting_Fever";
        }
        if (indeksSkill == 36)
        {
            skillImege.sprite = skillImages[36];
            nameSkill.text = "Crackling Lance";
            linkPoeDB = "Crackling_Lance";
        }
        if (indeksSkill == 37)
        {
            skillImege.sprite = skillImages[37];
            nameSkill.text = "Creeping Frost";
            linkPoeDB = "Creeping_Frost";
        }
        if (indeksSkill == 38)
        {
            skillImege.sprite = skillImages[38];
            nameSkill.text = "Cremation";
            linkPoeDB = "Cremation";
        }
        if (indeksSkill == 39)
        {
            skillImege.sprite = skillImages[39];
            nameSkill.text = "Cyclone";
            linkPoeDB = "Cyclone";
        }
        if (indeksSkill == 40)
        {
            skillImege.sprite = skillImages[40];
            nameSkill.text = "Dark Pact";
            linkPoeDB = "Dark_Pact";
        }
        if (indeksSkill == 41)
        {
            skillImege.sprite = skillImages[41];
            nameSkill.text = "Dash";
            linkPoeDB = "Dash";
        }
        if (indeksSkill == 42)
        {
            skillImege.sprite = skillImages[42];
            nameSkill.text = "Desecrate";
            linkPoeDB = "Desecrate";
        }
        if (indeksSkill == 43)
        {
            skillImege.sprite = skillImages[43];
            nameSkill.text = "Detonate Dead";
            linkPoeDB = "Detonate_Dead";
        }
        if (indeksSkill == 44)
        {
            skillImege.sprite = skillImages[44];
            nameSkill.text = "Discharge";
            linkPoeDB = "Discharge";
        }
        if (indeksSkill == 45)
        {
            skillImege.sprite = skillImages[45];
            nameSkill.text = "Divine Ire";
            linkPoeDB = "Divine_Ire";
        }
        if (indeksSkill == 46)
        {
            skillImege.sprite = skillImages[46];
            nameSkill.text = "Dominating Blow";
            linkPoeDB = "Dominating_Blow";
        }
        if (indeksSkill == 47)
        {
            skillImege.sprite = skillImages[47];
            nameSkill.text = "Double Strike";
            linkPoeDB = "Double_Strike";
        }
        if (indeksSkill == 48)
        {
            skillImege.sprite = skillImages[48];
            nameSkill.text = "Dual Strike";
            linkPoeDB = "Dual_Strike";
        }
        if (indeksSkill == 49)
        {
            skillImege.sprite = skillImages[49];
            nameSkill.text = "Earthquake";
            linkPoeDB = "Earthquake";
        }
        if (indeksSkill == 50)
        {
            skillImege.sprite = skillImages[50];
            nameSkill.text = "Earthshatter";
            linkPoeDB = "Earthshatter";
        }
        if (indeksSkill == 51)
        {
            skillImege.sprite = skillImages[51];
            nameSkill.text = "Elemental Hit";
            linkPoeDB = "Elemental_Hit";
        }
        if (indeksSkill == 52)
        {
            skillImege.sprite = skillImages[52];
            nameSkill.text = "Energy Blade";
            linkPoeDB = "Energy_Blade";
        }
        if (indeksSkill == 53)
        {
            skillImege.sprite = skillImages[53];
            nameSkill.text = "Ensnaring Arrow";
            linkPoeDB = "Ensnaring_Arrow";
        }
        if (indeksSkill == 54)
        {
            skillImege.sprite = skillImages[54];
            nameSkill.text = "Essence Drain";
            linkPoeDB = "Essence_Drain";
        }
        if (indeksSkill == 55)
        {
            skillImege.sprite = skillImages[55];
            nameSkill.text = "Ethereal Knives";
            linkPoeDB = "Ethereal_Knives";
        }
        if (indeksSkill == 56)
        {
            skillImege.sprite = skillImages[56];
            nameSkill.text = "Explosive Arrow";
            linkPoeDB = "Explosive_Arrow";
        }
        if (indeksSkill == 57)
        {
            skillImege.sprite = skillImages[57];
            nameSkill.text = "Explosive Concoction";
            linkPoeDB = "Explosive_Concoction";
        }
        if (indeksSkill == 58)
        {
            skillImege.sprite = skillImages[58];
            nameSkill.text = "Explosive Trap";
            linkPoeDB = "Explosive_Trap";
        }
        if (indeksSkill == 59)
        {
            skillImege.sprite = skillImages[59];
            nameSkill.text = "Exsanguinate";
            linkPoeDB = "Exsanguinate";
        }
        if (indeksSkill == 60)
        {
            skillImege.sprite = skillImages[60];
            nameSkill.text = "Eye of Winter";
            linkPoeDB = "Eye_of_Winter";
        }
        if (indeksSkill == 61)
        {
            skillImege.sprite = skillImages[61];
            nameSkill.text = "Fire Trap";
            linkPoeDB = "Fire_Trap";
        }
        if (indeksSkill == 62)
        {
            skillImege.sprite = skillImages[62];
            nameSkill.text = "Flame Wall";
            linkPoeDB = "Flame_Wall";
        }
        if (indeksSkill == 63)
        {
            skillImege.sprite = skillImages[63];
            nameSkill.text = "Fireball";
            linkPoeDB = "Fireball";
        }
        if (indeksSkill == 64)
        {
            skillImege.sprite = skillImages[64];
            nameSkill.text = "Firestorm";
            linkPoeDB = "Firestorm";
        }
        if (indeksSkill == 65)
        {
            skillImege.sprite = skillImages[65];
            nameSkill.text = "Flame Dash";
            linkPoeDB = "Flame_Dash";
        }
        if (indeksSkill == 66)
        {
            skillImege.sprite = skillImages[66];
            nameSkill.text = "Flame Surge";
            linkPoeDB = "Flame_Surge";
        }
        if (indeksSkill == 67)
        {
            skillImege.sprite = skillImages[67];
            nameSkill.text = "Flameblast";
            linkPoeDB = "Flameblast";
        }
        if (indeksSkill == 68)
        {
            skillImege.sprite = skillImages[68];
            nameSkill.text = "Flamethrower Trap";
            linkPoeDB = "Flamethrower_Trap";
        }
        if (indeksSkill == 69)
        {
            skillImege.sprite = skillImages[69];
            nameSkill.text = "Flicker Strike";
            linkPoeDB = "Flicker_Strike";
        }
        if (indeksSkill == 70)
        {
            skillImege.sprite = skillImages[70];
            nameSkill.text = "Forbidden Rite";
            linkPoeDB = "Forbidden_Rite";
        }
        if (indeksSkill == 71)
        {
            skillImege.sprite = skillImages[71];
            nameSkill.text = "Freezing Pulse";
            linkPoeDB = "Freezing_Pulse";
        }
        if (indeksSkill == 72)
        {
            skillImege.sprite = skillImages[72];
            nameSkill.text = "Frenzy";
            linkPoeDB = "Frenzy";
        }
        if (indeksSkill == 73)
        {
            skillImege.sprite = skillImages[73];
            nameSkill.text = "Frost Blades";
            linkPoeDB = "Frost_Blades";
        }
        if (indeksSkill == 74)
        {
            skillImege.sprite = skillImages[74];
            nameSkill.text = "Frost Bolt";
            linkPoeDB = "Frostbolt";
        }
        if (indeksSkill == 75)
        {
            skillImege.sprite = skillImages[75];
            nameSkill.text = "Frost Bomb";
            linkPoeDB = "Frost_Bomb";
        }
        if (indeksSkill == 76)
        {
            skillImege.sprite = skillImages[76];
            nameSkill.text = "Frost Wall";
            linkPoeDB = "Frost_Wall";
        }
        if (indeksSkill == 77)
        {
            skillImege.sprite = skillImages[77];
            nameSkill.text = "Frostblink";
            linkPoeDB = "Frostblink";
        }
        if (indeksSkill == 78)
        {
            skillImege.sprite = skillImages[78];
            nameSkill.text = "Galvanic Arrow";
            linkPoeDB = "Galvanic_Arrow";
        }
        if (indeksSkill == 79)
        {
            skillImege.sprite = skillImages[79];
            nameSkill.text = "Spectral Throw";
            linkPoeDB = "Spectral_Throw";
        }
        if (indeksSkill == 80)
        {
            skillImege.sprite = skillImages[80];
            nameSkill.text = "Glacial Cascade";
            linkPoeDB = "Glacial_Cascade";
        }
        if (indeksSkill == 81)
        {
            skillImege.sprite = skillImages[81];
            nameSkill.text = "Glacial Hammer";
            linkPoeDB = "Glacial_Hammer";
        }
        if (indeksSkill == 82)
        {
            skillImege.sprite = skillImages[82];
            nameSkill.text = "Ground Slam";
            linkPoeDB = "Ground_Slam";
        }
        if (indeksSkill == 83)
        {
            skillImege.sprite = skillImages[83];
            nameSkill.text = "Heavy Strike";
            linkPoeDB = "Heavy_Strike";
        }
        if (indeksSkill == 84)
        {
            skillImege.sprite = skillImages[84];
            nameSkill.text = "Hexblast";
            linkPoeDB = "Hexblast";
        }
        if (indeksSkill == 85)
        {
            skillImege.sprite = skillImages[85];
            nameSkill.text = "Holy Flame Totem";
            linkPoeDB = "Holy_Flame_Totem";
        }
        if (indeksSkill == 86)
        {
            skillImege.sprite = skillImages[86];
            nameSkill.text = "Summon Holy Relic";
            linkPoeDB = "Summon_Holy_Relic";
        }
        if (indeksSkill == 87)
        {
            skillImege.sprite = skillImages[87];
            nameSkill.text = "Hydrosphere";
            linkPoeDB = "Hydrosphere";
        }
        if (indeksSkill == 88)
        {
            skillImege.sprite = skillImages[88];
            nameSkill.text = "Ice Crash";
            linkPoeDB = "Ice_Crash";
        }
        if (indeksSkill == 89)
        {
            skillImege.sprite = skillImages[89];
            nameSkill.text = "Ice Nova";
            linkPoeDB = "Ice_Nova";
        }
        if (indeksSkill == 90)
        {
            skillImege.sprite = skillImages[90];
            nameSkill.text = "Ice Shot";
            linkPoeDB = "Ice_Shot";
        }
        if (indeksSkill == 91)
        {
            skillImege.sprite = skillImages[91];
            nameSkill.text = "Ice Spear";
            linkPoeDB = "Ice_Spear";
        }
        if (indeksSkill == 92)
        {
            skillImege.sprite = skillImages[92];
            nameSkill.text = "Ice Trap";
            linkPoeDB = "Ice_Trap";
        }
        if (indeksSkill == 93)
        {
            skillImege.sprite = skillImages[92];
            nameSkill.text = "Icicle Mine";
            linkPoeDB = "Icicle_Mine";
        }
        if (indeksSkill == 94)
        {
            skillImege.sprite = skillImages[94];
            nameSkill.text = "Incinerate";
            linkPoeDB = "Incinerate";
        }
        if (indeksSkill == 95)
        {
            skillImege.sprite = skillImages[95];
            nameSkill.text = "Infernal Blow";
            linkPoeDB = "Infernal_Blow";
        }
        if (indeksSkill == 96)
        {
            skillImege.sprite = skillImages[96];
            nameSkill.text = "Kinetic Blast";
            linkPoeDB = "Kinetic_Blast";
        }
        if (indeksSkill == 97)
        {
            skillImege.sprite = skillImages[97];
            nameSkill.text = "Kinetic Bolt";
            linkPoeDB = "Kinetic_Bolt";
        }
        if (indeksSkill == 98)
        {
            skillImege.sprite = skillImages[98];
            nameSkill.text = "Lacerate";
            linkPoeDB = "Lacerate";
        }
        if (indeksSkill == 99)
        {
            skillImege.sprite = skillImages[99];
            nameSkill.text = "Lancing Steel";
            linkPoeDB = "Lancing_Steel";
        }
        if (indeksSkill == 100)
        {
            skillImege.sprite = skillImages[100];
            nameSkill.text = "Leap Slam";
            linkPoeDB = "Leap_Slam";
        }
        if (indeksSkill == 101)
        {
            skillImege.sprite = skillImages[101];
            nameSkill.text = "Lightning Tendrils";
            linkPoeDB = "Lightning_Tendrils";
        }
        if (indeksSkill == 102)
        {
            skillImege.sprite = skillImages[102];
            nameSkill.text = "Lightning Arrow";
            linkPoeDB = "Lightning_Arrow";
        }
        if (indeksSkill == 103)
        {
            skillImege.sprite = skillImages[103];
            nameSkill.text = "Lightning Spire Trap";
            linkPoeDB = "Lightning_Spire_Trap";
        }
        if (indeksSkill == 104)
        {
            skillImege.sprite = skillImages[104];
            nameSkill.text = "Lightning Strike";
            linkPoeDB = "Lightning_Strike";
        }
        if (indeksSkill == 105)
        {
            skillImege.sprite = skillImages[105];
            nameSkill.text = "Lightning Trap";
            linkPoeDB = "Lightning_Trap";
        }
        if (indeksSkill == 106)
        {
            skillImege.sprite = skillImages[106];
            nameSkill.text = "Lightning Warp";
            linkPoeDB = "Lightning_Warp";
        }
        if (indeksSkill == 107)
        {
            skillImege.sprite = skillImages[107];
            nameSkill.text = "Manabond";
            linkPoeDB = "Manabond";
        }
        if (indeksSkill == 108)
        {
            skillImege.sprite = skillImages[108];
            nameSkill.text = "Mirror Arrow";
            linkPoeDB = "Mirror_Arrow";
        }
        if (indeksSkill == 109)
        {
            skillImege.sprite = skillImages[109];
            nameSkill.text = "Molten Strike";
            linkPoeDB = "Molten_Strike";
        }
        if (indeksSkill == 110)
        {
            skillImege.sprite = skillImages[110];
            nameSkill.text = "Orb of Storms";
            linkPoeDB = "Orb_of_Storms";
        }
        if (indeksSkill == 111)
        {
            skillImege.sprite = skillImages[111];
            nameSkill.text = "Penance Brand";
            linkPoeDB = "Penance_Brand";
        }
        if (indeksSkill == 112)
        {
            skillImege.sprite = skillImages[112];
            nameSkill.text = "Perforate";
            linkPoeDB = "Perforate";
        }
        if (indeksSkill == 113)
        {
            skillImege.sprite = skillImages[113];
            nameSkill.text = "Pestilent Strike";
            linkPoeDB = "Pestilent_Strike";
        }
        if (indeksSkill == 114)
        {
            skillImege.sprite = skillImages[114];
            nameSkill.text = "Pyroclast Mine";
            linkPoeDB = "Pyroclast_Mine";
        }
        if (indeksSkill == 115)
        {
            skillImege.sprite = skillImages[115];
            nameSkill.text = "Plague Bearer";
            linkPoeDB = "Plague_Bearer";
        }
        if (indeksSkill == 116)
        {
            skillImege.sprite = skillImages[116];
            nameSkill.text = "Poisonous Concoction";
            linkPoeDB = "Poisonous_Concoction";
        }
        if (indeksSkill == 117)
        {
            skillImege.sprite = skillImages[117];
            nameSkill.text = "Power Siphon";
            linkPoeDB = "Power_Siphon";
        }
        if (indeksSkill == 118)
        {
            skillImege.sprite = skillImages[118];
            nameSkill.text = "Puncture";
            linkPoeDB = "Puncture";
        }
        if (indeksSkill == 119)
        {
            skillImege.sprite = skillImages[119];
            nameSkill.text = "Purifying Flame";
            linkPoeDB = "Purifying_Flame";
        }
        if (indeksSkill == 120)
        {
            skillImege.sprite = skillImages[120];
            nameSkill.text = "Rage Vortex";
            linkPoeDB = "Rage_Vortex";
        }
        if (indeksSkill == 121)
        {
            skillImege.sprite = skillImages[121];
            nameSkill.text = "Rain of Arrows";
            linkPoeDB = "Rain_of_Arrows";
        }
        if (indeksSkill == 122)
        {
            skillImege.sprite = skillImages[122];
            nameSkill.text = "Raise Spectre";
            linkPoeDB = "Raise_Spectre";
        }
        if (indeksSkill == 123)
        {
            skillImege.sprite = skillImages[123];
            nameSkill.text = "Raise Zombie";
            linkPoeDB = "Raise_Zombie";
        }
        if (indeksSkill == 124)
        {
            skillImege.sprite = skillImages[124];
            nameSkill.text = "Reap";
            linkPoeDB = "Reap";
        }
        if (indeksSkill == 125)
        {
            skillImege.sprite = skillImages[125];
            nameSkill.text = "Reave";
            linkPoeDB = "Reave";
        }
        if (indeksSkill == 126)
        {
            skillImege.sprite = skillImages[126];
            nameSkill.text = "Righteous Fire";
            linkPoeDB = "Righteous_Fire";
        }
        if (indeksSkill == 127)
        {
            skillImege.sprite = skillImages[127];
            nameSkill.text = "Rolling Magma";
            linkPoeDB = "Rolling_Magma";
        }
        if (indeksSkill == 128)
        {
            skillImege.sprite = skillImages[128];
            nameSkill.text = "Scorching Ray";
            linkPoeDB = "Scorching_Ray";
        }
        if (indeksSkill == 129)
        {
            skillImege.sprite = skillImages[129];
            nameSkill.text = "Scourge Arrow";
            linkPoeDB = "Scourge_Arrow";
        }
        if (indeksSkill == 130)
        {
            skillImege.sprite = skillImages[130];
            nameSkill.text = "Searing Bond";
            linkPoeDB = "Searing_Bond";
        }
        if (indeksSkill == 131)
        {
            skillImege.sprite = skillImages[131];
            nameSkill.text = "Seismic Trap";
            linkPoeDB = "Seismic_Trap";
        }
        if (indeksSkill == 132)
        {
            skillImege.sprite = skillImages[132];
            nameSkill.text = "Shattering Steel";
            linkPoeDB = "Shattering_Steel";
        }
        if (indeksSkill == 133)
        {
            skillImege.sprite = skillImages[133];
            nameSkill.text = "Shield Charge";
            linkPoeDB = "Shield_Charge";
        }
        if (indeksSkill == 134)
        {
            skillImege.sprite = skillImages[134];
            nameSkill.text = "Shield Crush";
            linkPoeDB = "Shield_Crush";
        }
        if (indeksSkill == 135)
        {
            skillImege.sprite = skillImages[135];
            nameSkill.text = "Shock Nova";
            linkPoeDB = "Shock_Nova";
        }
        if (indeksSkill == 136)
        {
            skillImege.sprite = skillImages[136];
            nameSkill.text = "Shockwave Totem";
            linkPoeDB = "Shockwave_Totem";
        }
        if (indeksSkill == 137)
        {
            skillImege.sprite = skillImages[137];
            nameSkill.text = "Shrapnel Ballista";
            linkPoeDB = "Shrapnel_Ballista";
        }
        if (indeksSkill == 138)
        {
            skillImege.sprite = skillImages[138];
            nameSkill.text = "Siphoning Trap";
            linkPoeDB = "Siphoning_Trap";
        }
        if (indeksSkill == 139)
        {
            skillImege.sprite = skillImages[139];
            nameSkill.text = "Siege Ballista";
            linkPoeDB = "Siege_Ballista";
        }
        if (indeksSkill == 140)
        {
            skillImege.sprite = skillImages[140];
            nameSkill.text = "Sigil of Power";
            linkPoeDB = "Sigil_of_Power";
        }
        if (indeksSkill == 141)
        {
            skillImege.sprite = skillImages[141];
            nameSkill.text = "Smite";
            linkPoeDB = "Smite";
        }
        if (indeksSkill == 141)
        {
            skillImege.sprite = skillImages[141];
            nameSkill.text = "Smoke Mine";
            linkPoeDB = "Smoke_Mine";
        }
        if (indeksSkill == 142)
        {
            skillImege.sprite = skillImages[142];
            nameSkill.text = "Soulrend";
            linkPoeDB = "Soulrend";
        }
        if (indeksSkill == 143)
        {
            skillImege.sprite = skillImages[143];
            nameSkill.text = "Spark";
            linkPoeDB = "Spark";
        }
        if (indeksSkill == 144)
        {
            skillImege.sprite = skillImages[144];
            nameSkill.text = "Spectral Helix";
            linkPoeDB = "Spectral_Helix";
        }
        if (indeksSkill == 145)
        {
            skillImege.sprite = skillImages[145];
            nameSkill.text = "Spectral Shield Throw";
            linkPoeDB = "Spectral_Shield_Throw";
        }
        if (indeksSkill == 146)
        {
            skillImege.sprite = skillImages[146];
            nameSkill.text = "Split Arrow";
            linkPoeDB = "Split_Arrow";
        }
        if (indeksSkill == 147)
        {
            skillImege.sprite = skillImages[147];
            nameSkill.text = "Splitting Steel";
            linkPoeDB = "Splitting_Steel";
        }
        if (indeksSkill == 148)
        {
            skillImege.sprite = skillImages[148];
            nameSkill.text = "Static Strike";
            linkPoeDB = "Static_Strike";
        }
        if (indeksSkill == 149)
        {
            skillImege.sprite = skillImages[149];
            nameSkill.text = "Storm Brand";
            linkPoeDB = "Storm_Brand";
        }
        if (indeksSkill == 150)
        {
            skillImege.sprite = skillImages[150];
            nameSkill.text = "Storm Burst";
            linkPoeDB = "Storm_Burst";
        }
        if (indeksSkill == 151)
        {
            skillImege.sprite = skillImages[151];
            nameSkill.text = "Storm Call";
            linkPoeDB = "Storm_Call";
        }
        if (indeksSkill == 152)
        {
            skillImege.sprite = skillImages[152];
            nameSkill.text = "Storm Rain";
            linkPoeDB = "Storm_Rain";
        }
        if (indeksSkill == 153)
        {
            skillImege.sprite = skillImages[153];
            nameSkill.text = "Stormbind";
            linkPoeDB = "Stormbind";
        }
        if (indeksSkill == 154)
        {
            skillImege.sprite = skillImages[154];
            nameSkill.text = "Stormblast Mine";
            linkPoeDB = "Stormblast_Mine";
        }
        if (indeksSkill == 155)
        {
            skillImege.sprite = skillImages[155];
            nameSkill.text = "Summon Carrion Golem";
            linkPoeDB = "Summon_Carrion_Golem";
        }
        if (indeksSkill == 156)
        {
            skillImege.sprite = skillImages[156];
            nameSkill.text = "Summon Chaos Golem";
            linkPoeDB = "Summon_Chaos_Golem";
        }
        if (indeksSkill == 157)
        {
            skillImege.sprite = skillImages[157];
            nameSkill.text = "Summon Flame Golem";
            linkPoeDB = "Summon_Flame_Golem";
        }
        if (indeksSkill == 158)
        {
            skillImege.sprite = skillImages[158];
            nameSkill.text = "Summon Ice Golem";
            linkPoeDB = "Summon_Ice_Golem";
        }
        if (indeksSkill == 159)
        {
            skillImege.sprite = skillImages[159];
            nameSkill.text = "Summon Lightning Golem";
            linkPoeDB = "Summon_Lightning_Golem";
        }
        if (indeksSkill == 160)
        {
            skillImege.sprite = skillImages[160];
            nameSkill.text = "Summon Raging Spirit";
            linkPoeDB = "Summon_Raging_Spirit";
        }
        if (indeksSkill == 161)
        {
            skillImege.sprite = skillImages[161];
            nameSkill.text = "Summon Reaper";
            linkPoeDB = "Summon_Reaper";
        }
        if (indeksSkill == 162)
        {
            skillImege.sprite = skillImages[162];
            nameSkill.text = "Summon Skeletons";
            linkPoeDB = "Summon_Skeletons";
        }
        if (indeksSkill == 163)
        {
            skillImege.sprite = skillImages[163];
            nameSkill.text = "Summon Stone Golem";
            linkPoeDB = "Summon_Stone_Golem";
        }
        if (indeksSkill == 164)
        {
            skillImege.sprite = skillImages[164];
            nameSkill.text = "Sunder";
            linkPoeDB = "Sunder";
        }
        if (indeksSkill == 165)
        {
            skillImege.sprite = skillImages[165];
            nameSkill.text = "Sweep";
            linkPoeDB = "Sweep";
        }
        if (indeksSkill == 166)
        {
            skillImege.sprite = skillImages[166];
            nameSkill.text = "Tectonic Slam";
            linkPoeDB = "Tectonic_Slam";
        }
        if (indeksSkill == 167)
        {
            skillImege.sprite = skillImages[167];
            nameSkill.text = "Tornado Shot";
            linkPoeDB = "Tornado_Shot";
        }
        if (indeksSkill == 168)
        {
            skillImege.sprite = skillImages[168];
            nameSkill.text = "Tornado";
            linkPoeDB = "Tornado";
        }
        if (indeksSkill == 169)
        {
            skillImege.sprite = skillImages[169];
            nameSkill.text = "Toxic Rain";
            linkPoeDB = "Toxic_Rain";
        }
        if (indeksSkill == 170)
        {
            skillImege.sprite = skillImages[170];
            nameSkill.text = "Unearth";
            linkPoeDB = "Unearth";
        }
        if (indeksSkill == 171)
        {
            skillImege.sprite = skillImages[171];
            nameSkill.text = "Venom Gyre";
            linkPoeDB = "Venom_Gyre";
        }
        if (indeksSkill == 172)
        {
            skillImege.sprite = skillImages[172];
            nameSkill.text = "Vigilant Strike";
            linkPoeDB = "Vigilant_Strike";
        }
        if (indeksSkill == 173)
        {
            skillImege.sprite = skillImages[173];
            nameSkill.text = "Viper Strike";
            linkPoeDB = "Viper_Strike";
        }
        if (indeksSkill == 174)
        {
            skillImege.sprite = skillImages[174];
            nameSkill.text = "Void Sphere";
            linkPoeDB = "Void_Sphere";
        }
        if (indeksSkill == 175)
        {
            skillImege.sprite = skillImages[175];
            nameSkill.text = "Volatile Dead";
            linkPoeDB = "Volatile_Dead";
        }
        if (indeksSkill == 176)
        {
            skillImege.sprite = skillImages[176];
            nameSkill.text = "Voltaxic Burst";
            linkPoeDB = "Voltaxic_Burst";
        }
        if (indeksSkill == 177)
        {
            skillImege.sprite = skillImages[177];
            nameSkill.text = "Vortex";
            linkPoeDB = "Vortex";
        }
        if (indeksSkill == 178)
        {
            skillImege.sprite = skillImages[178];
            nameSkill.text = "Wave of Conviction";
            linkPoeDB = "Wave_of_Conviction";
        }
        if (indeksSkill == 179)
        {
            skillImege.sprite = skillImages[179];
            nameSkill.text = "Whirling Blades";
            linkPoeDB = "Whirling_Blades";
        }
        if (indeksSkill == 180)
        {
            skillImege.sprite = skillImages[180];
            nameSkill.text = "Wild Strike";
            linkPoeDB = "Wild_Strike";
        }
        if (indeksSkill == 181)
        {
            skillImege.sprite = skillImages[181];
            nameSkill.text = "Winter Orb";
            linkPoeDB = "Winter_Orb";
        }
        if (indeksSkill == 182)
        {
            skillImege.sprite = skillImages[182];
            nameSkill.text = "Wintertide Brand";
            linkPoeDB = "Wintertide_Brand";
        }
    }

    public void GoToPoeDBSite()
    {
        Application.OpenURL("https://poedb.tw/us/" + linkPoeDB);
    }

    void ShowSkillAtributes()
    {
        if (randomizeSkillEnd == true)
        {
            skillImege.gameObject.SetActive(true);
            nameSkill.gameObject.SetActive(true);
            restartButton.SetActive(true);
            quitButton.SetActive(true);
            startRollButton.interactable = false;
        }
    }
}
