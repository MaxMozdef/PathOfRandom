using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiseSkill : MonoBehaviour
{
    [SerializeField] GameObject choiseSkillPanel, coiseCharakterButtons;
    [SerializeField] Image classImage;
    [SerializeField] List<Sprite> listOfClasses;

    int indexListOfClasses;

    private void Update()
    {
        showClassImage();
        classImage.sprite = listOfClasses[indexListOfClasses];
    }

    public void OpenSkillPanel()
    {
        choiseSkillPanel.SetActive(true);
        coiseCharakterButtons.SetActive(false);
    }

    void showClassImage()
    {
        if (InheritedClass.nameClass == "Ascendant")
            indexListOfClasses = 0;
        if (InheritedClass.nameClass == "Assassin")
            indexListOfClasses = 1;
        if (InheritedClass.nameClass == "Berserker")
            indexListOfClasses = 2;
        if (InheritedClass.nameClass == "Champion")
            indexListOfClasses = 3;
        if (InheritedClass.nameClass == "Chieftain")
            indexListOfClasses = 4;
        if (InheritedClass.nameClass == "Deadeye")
            indexListOfClasses = 5;
        if (InheritedClass.nameClass == "Elementalist")
            indexListOfClasses = 6;
        if (InheritedClass.nameClass == "Gladiator")
            indexListOfClasses = 7;
        if (InheritedClass.nameClass == "Guardian")
            indexListOfClasses = 8;
        if (InheritedClass.nameClass == "Hierophant")
            indexListOfClasses = 9;
        if (InheritedClass.nameClass == "Inquisitor")
            indexListOfClasses = 10;
        if (InheritedClass.nameClass == "Juggernaut")
            indexListOfClasses = 11;
        if (InheritedClass.nameClass == "Necromancer")
            indexListOfClasses = 12;
        if (InheritedClass.nameClass == "Occultist")
            indexListOfClasses = 13;
        if (InheritedClass.nameClass == "Pathfinder")
            indexListOfClasses = 14;
        if (InheritedClass.nameClass == "Raider")
            indexListOfClasses = 15;
        if (InheritedClass.nameClass == "Saboteur")
            indexListOfClasses = 16;
        if (InheritedClass.nameClass == "Slayer")
            indexListOfClasses = 17;
        if (InheritedClass.nameClass == "Trickster")
            indexListOfClasses = 18;
    }
}
