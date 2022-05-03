using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoToSite : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI goToPathOfExileSite;
    [SerializeField] Button nameClassLink;

    string linkOnClass;

    private void Update()
    {
        CreatesLinkToNameClasses();
    }

    public void goToPathOfExileSiteLogic()
    {
        Application.OpenURL(linkOnClass);
    }

    void CreatesLinkToNameClasses()
    {
        if (nameClassLink.gameObject.activeSelf == true)
        {
            switch (goToPathOfExileSite.text)
            {
                case "Juggernaut":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Juggernaut";
                    break;
                case "Pathfinder":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Pathfinder";
                    break;
                case "Berserker":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Berserker";
                    break;
                case "Chieftain":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Chieftain";
                    break;
                case "Raider":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Raider";
                    break;
                case "Deadeye":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Deadeye";
                    break;
                case "Slayer":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Slayer";
                    break;
                case "Gladiator":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Gladiator";
                    break;
                case "Champion":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Champion";
                    break;
                case "Assassin":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Assassin";
                    break;
                case "Saboteur":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Saboteur";
                    break;
                case "Trickster":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Trickster";
                    break;
                case "Occultist":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Occultist";
                    break;
                case "Necromancer":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Necromancer";
                    break;
                case "Elementalist":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Elementalist";
                    break;
                case "Inquisitor":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Inquisitor";
                    break;
                case "Hierophant":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Hierophant";
                    break;
                case "Guardian":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Guardian";
                    break;
                case "Ascendant":
                    linkOnClass = "https://www.pathofexile.com/ascendancy/classes/Ascendant";
                    break;
            }
        }
    }
}
