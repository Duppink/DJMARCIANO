using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flechitas : MonoBehaviour
{

    public GameObject[] flechas;
    public TextMeshProUGUI[] misiones;

    public GameManager gm = null;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.ArtChic_Friend_ParkourBoy == true || gm.ParkourBoy_Friend_ArtChic == true)
        {
            flechas[0].SetActive(true);
        }

        if (gm.ParkourBoy_Love_PopularGirl == true)
        {
            flechas[1].SetActive(true);
        }

        if (gm.ClassPresident_Friend_PopularGirl == true || gm.PopularGirl_Friend_ClassPresident == true)
        {
            flechas[2].SetActive(true);
        }

        if (gm.ArtChic_Love_PopularGirl == true || gm.PopularGirl_Love_ArtChic == true)
        {
            flechas[3].SetActive(true);
        }

        if (gm.BandMember_Love_Sport == true || gm.Sport_Love_BandMember == true)
        {
            flechas[4].SetActive(true);
        }

        if (gm.Esoteric_Friend_ArtChic == true)
        {
            flechas[5].SetActive(true);
        }

        if (gm.Esoteric_Love_Stoner == true)
        {
            flechas[6].SetActive(true);
        }

        if (gm.BandMember_Friend_PopularGirl == true)
        {
            flechas[7].SetActive(true);
        }

        if (gm.Sport_Friend_ClassPresident == true || gm.ClassPresident_Friend_Sport == true)
        {
            flechas[8].SetActive(true);
        }

        if (gm.Stoner_Friend_Sport == true)
        {
            flechas[9].SetActive(true);
        }

        if (gm.Stoner_Friend_Esoteric == true)
        {
            flechas[10].SetActive(true);
        }

        ///// MISIONES TEXTO

        if (gm.Mision1_Meteoro == true)
        {
            misiones[0].text = "El presidente de la clase le mando como chiste un globo meteorito a lopez, su pana.";
        }

        else
        {
            misiones[0].text = "?????";
        }

        ///

        if (gm.Mision2_AgujeroNegro == true)
        {
            misiones[1].text = "los humanos relacionan la gravedad del agujero negro con la atraccion romantica.";
        }

        else
        {
            misiones[1].text = "?????";
        }

        ///

        if (gm.Mision3_UFO == true)
        {
            misiones[2].text = "creo que la chica del afro me mando el globo u.f.o solo de buena onda... menos mal.";
        }

        else
        {
            misiones[2].text = "?????";
        }

    }
}
