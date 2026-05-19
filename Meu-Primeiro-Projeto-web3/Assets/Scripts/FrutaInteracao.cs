using UnityEngine;

// Biblioteca do Meta XR SDK responsável pelas interações em VR
using Oculus.Interaction;

// Classe responsável pela interação das frutas no ambiente VR
public class FrutaInteracao : MonoBehaviour
{
    // Referência para o componente de áudio da fruta
    private AudioSource audioSource;

    // Referência para o componente responsável pelo sistema de grab
    private Grabbable grabbable;

    // Variável de controle para impedir que o som toque várias vezes
    // continuamente enquanto a fruta permanece segurada
    private bool jaPegou = false;

    // Método executado automaticamente quando o jogo inicia
    void Start()
    {
        // Busca o componente AudioSource no objeto atual
        audioSource = GetComponent<AudioSource>();

        // Busca o componente Grabbable do Meta XR SDK
        grabbable = GetComponent<Grabbable>();

        // Verifica se o objeto possui AudioSource
        if (audioSource == null)
            Debug.LogError("Falta AudioSource na fruta.");

        // Verifica se o objeto possui Grabbable
        if (grabbable == null)
            Debug.LogError("Falta Grabbable na fruta.");
    }

    // Método executado continuamente a cada frame
    void Update()
    {
        // Verifica se:
        // - existe um componente Grabbable;
        // - a fruta está sendo segurada;
        // - o som ainda não foi executado
        if (grabbable != null && grabbable.SelectingPointsCount > 0 && !jaPegou)
        {
            // Chama o método responsável pela interação
            AoPegarFruta();

            // Impede repetição contínua do som
            jaPegou = true;
        }

        // Quando o jogador solta a fruta
        if (grabbable != null && grabbable.SelectingPointsCount == 0)
        {
            // Permite que o som possa tocar novamente
            // na próxima interação
            jaPegou = false;
        }
    }

    // Método responsável pela interação da fruta
    public void AoPegarFruta()
    {
        // Mensagem exibida no Console da Unity
        Debug.Log("Fruta pegada!");

        // Verifica se existe AudioSource
        if (audioSource != null)
        {
            // Reproduz o som da fruta
            audioSource.Play();
        }
    }
}