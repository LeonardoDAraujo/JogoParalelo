using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuPrincipal;
    [SerializeField] private GameObject painelOpcoes;

    public void jogar()
    {
          SceneManager.LoadScene("SampleScene");

    }

    public void AbrirOpcoes()
    {
     painelMenuPrincipal.SetActive(false);
     painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
     painelOpcoes.SetActive(false);
     painelMenuPrincipal.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();

    }
}
