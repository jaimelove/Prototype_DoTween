using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquishySquare : MonoBehaviour
{
    [SerializeField] private float _cycleLength = 2f;

    [SerializeField] private Vector3[] path;

    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        //transform.DOPath(path, _cycleLength, PathType.CatmullRom)
        //    .SetEase(Ease.InOutSine)
        //    .SetLoops(-1, LoopType.Restart);

        //transform.DOMove(new Vector3(5, 5, 0), _cycleLength)
        //    .SetEase(Ease.Linear)
        //    .SetLoops(-1, LoopType.Yoyo)
        //    .OnStepComplete(Bounce);
        Bounce();
    }

    void Bounce()
    {
        camera.DORestart();

        transform.DOShakeScale(0.5f);

        camera.DOShakePosition(1f, 1f);
    }
}
