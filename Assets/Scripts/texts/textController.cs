using TMPro;
using UnityEngine;
public class textController : MonoBehaviour
{
    public gameManager gameManager; // reference to your game manager
    public TextMeshProUGUI displayText; // or UnityEngine.UI.Text

    void Update()
    {
        switch(gameManager.Instance.globeTargetIndex)
        {
            case -1:
                displayText.text = "Este é o planeta em que vivemos, o planeta Terra. Ele tem formato  arredondado  e gira em torno do Sol. Vamos dar uma volta por aí para  visitarmos dois lugares incríveis e pouco conhecidos: as nossas regiões polares!";
                break;
            case 0:
                displayText.text = "Vamos partir do Brasil, um país grande e de clima predominantemente tropical, ele bem diferente das gélidas regiões polares... Agora vamos viajar para o extremo norte e para o extremo sul e   aprender sobre esses lugares fascinantes!";
                break;
            case 1:
                displayText.text = "Chegamos ao Ártico! Nele fica o Polo Norte, lá no topo do planeta. Tem cerca de 21 milhões de km²! Aqui faz muito frio, média de -2°C, e possui uma grande área oceânica, porém boa parte da  água está congelada, formando o gelo marinho";
                break;
            case 2:
                displayText.text = "No Ártico vivem ursos-polares, morsas, raposas-do-ártico e muitos outros animais... Há poucas plantas por causa do frio, porém o bioma de tundra está presente em algumas regiões.. Os Inuítes formam um dos grupos de pessoas que também moram aqui!";
                break;
            case 3:
                displayText.text = "Agora chegamos  na Antártica, onde fica o Polo Sul. Ela é um continente enorme, com quase 14 milhões de km², quase todo coberto de gelo! Aqui não existem cidades, apenas estações de pesquisa e navios que visitam a região no verão.  A temperatura média da Antártica é ainda mais baixa do que o Ártico, -55°C!.";
                break;
            case 4:
                displayText.text = "Na Antártida vivem pinguins, skuas, krills e outros animais adaptados ao  frio. Não há árvores, mas existem algas, líquens e musgos. É um lugar importante para os cientistas estudarem a biodiversidade e o clima da Terra.";
                break;
            default:
                displayText.text = "";
                break;
        }
    }
}
