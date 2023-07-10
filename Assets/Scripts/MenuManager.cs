using DG.Tweening;
using System.Collections;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject headlerOBJ, SDBTTN, DDBTTN;

    IEnumerator GetscreenSceneElementsRoutine()
    {
        headlerOBJ.GetComponent<CanvasGroup>().DOFade(1, 1f);
        headlerOBJ.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.2f);

        SDBTTN.GetComponent<CanvasGroup>().DOFade(1, 1f);
        SDBTTN.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.2f);

        DDBTTN.GetComponent<CanvasGroup>().DOFade(1, 1f);
        DDBTTN.GetComponent<RectTransform>().DOLocalMoveY(-600, 1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.2f);
    }

}
